using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableInt : IPatchProperty<int?>
    {
        public int? Value { get; set; }
    }
}
