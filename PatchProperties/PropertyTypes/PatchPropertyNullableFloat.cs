using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableFloat : IPatchProperty<float?>
    {
        public float? Value { get; set; }
    }
}
