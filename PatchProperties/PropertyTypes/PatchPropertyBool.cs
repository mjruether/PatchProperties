using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyBool : IPatchProperty<bool>
    {
        public bool Value { get; set; }
    }
}
