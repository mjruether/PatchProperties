using PatchProperties.Domain.Responses;
using PatchProperties.Extensions;
using System.Reflection;

namespace PatchProperties
{
    public class PatchPropertyService
    {
        private readonly NullabilityInfoContext _nullabilityContext = new NullabilityInfoContext();

        public bool IgnoreUnmatchedProperties { get; set; } = false;

        public PatchPropertyService()
        {
        }

        public SetValuesResponse<E> SetValues<E, I>(E patchableEntity, I patchModel) where E : class
        {
            if (patchModel == null)
            {
                return new SetValuesResponse<E>(patchableEntity);
            }

            // Get all properties of the patch model and set their values on the patchable entity
            var patchModelProperties = patchModel.GetType().GetProperties();

            Dictionary<string, string> warnings = new Dictionary<string, string>();
            Dictionary<string, string> ignoredWarnings = new Dictionary<string, string>();

            foreach (var patchModelProperty in patchModelProperties)
            {
                var patchProperty = patchModelProperty.GetValue(patchModel);

                if (patchProperty == null)
                {
                    // Null property indicates no change to apply.  Skip update to this property.
                    continue;
                }

                var patchPropertyType = patchProperty.GetType();
                var patchPropertyTypeInterface = patchPropertyType.GetInterface("IPatchProperty`1");

                // It implements the interface, so should therefor have a Value property
                if (patchPropertyTypeInterface != null)
                {
                    // Get type of the interface implementation
                    var patchPropertyTypeGeneric = patchPropertyTypeInterface.GenericTypeArguments[0];

                    var patchPropertyPropertyInfo = patchProperty.GetType().GetProperty("Value");

                    // The prior check for this property implementing IPatchProperty guarantees that the "Value" property will exist
                    var value = patchPropertyPropertyInfo!.GetValue(patchProperty);

                    // Find if the patchable entity has a property with the same name
                    var patchableEntityProperty = patchableEntity.GetType().GetProperty(patchModelProperty.Name);
                    if (patchableEntityProperty != null)
                    {
                        // Set the patchableEntityProperty with the value from patchModelProperty
                        try
                        {
                            if (value == null)
                            {
                                var nullabilityInfo = _nullabilityContext.Create(patchPropertyPropertyInfo);
                                if (nullabilityInfo.WriteState is not NullabilityState.Nullable)
                                {
                                    var warningMessage = $"{patchModelProperty.Name} contained a a null value, which could not be set on {patchPropertyTypeGeneric.Name} property.";
                                    warnings.Add(patchModelProperty.Name, warningMessage);
                                    continue;
                                }

                                patchableEntityProperty.SetValue(patchableEntity, null);
                                continue;
                            }
                            var typedValue = patchableEntityProperty.PropertyType.ChangeValueType(value);

                            patchableEntityProperty.SetValue(patchableEntity, typedValue);
                        }
                        catch (FormatException)
                        {
                            var warningMessage = $"{patchModelProperty.Name} expected a {patchableEntityProperty.PropertyType} but instead received a {patchPropertyTypeGeneric.Name}";
                            warnings.Add(patchModelProperty.Name, warningMessage);
                        }
                    }
                    else
                    {
                        var warningMessage = $"{patchModelProperty.Name} did not match and properties of the entity to update";
                        if (IgnoreUnmatchedProperties)
                        {
                            ignoredWarnings.Add(patchModelProperty.Name, warningMessage); 
                        }
                        else
                        {
                            warnings.Add(patchModelProperty.Name, warningMessage);
                        }
                    }
                }
            }

            return new SetValuesResponse<E>(
                patchableEntity,
                warnings);
        }
    }
}
