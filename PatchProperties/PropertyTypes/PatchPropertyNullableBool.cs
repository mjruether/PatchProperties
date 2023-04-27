using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableBool : IPatchProperty<bool?>
    {
        public bool? Value { get; set; }
    }
}