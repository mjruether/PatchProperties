using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties
{
    public class PatchPropertyService
    {
        public E SetValues<E, I>(E patchableEntity, I patchModel) where E : class
        {
            // Get all properties of the patch model and set their values on the patchable entity
            var patchModelProperties = patchModel.GetType().GetProperties();
            foreach (var patchModelProperty in patchModelProperties)
            {
                var patchProperty = patchModelProperty.GetValue(patchModel);
                var patchPropertyType = patchProperty.GetType();
                var patchPropertyTypeInterface = patchPropertyType.GetInterface("IPatchProperty`1");

                // It implements the interface, so should therefor have a Value property
                if (patchPropertyTypeInterface != null)
                {
                    // Get type of the interface implementation
                    var patchPropertyTypeGeneric = patchPropertyTypeInterface.GenericTypeArguments[0];

                    var patchPropertyPropertyInfo = patchProperty.GetType().GetProperty("Value");
                    var value = patchPropertyPropertyInfo.GetValue(patchProperty);

                    // Find if the patchable entity has a property with the same name
                    var patchableEntityProperty = patchableEntity.GetType().GetProperty(patchModelProperty.Name);
                    if (patchableEntityProperty != null)
                    {
                        // Set the patchableEntityProperty with the value from patchModelProperty
                        patchableEntityProperty.SetValue(patchableEntity, value);
                    }
                }
            }

            return patchableEntity;
        }
    }
}
