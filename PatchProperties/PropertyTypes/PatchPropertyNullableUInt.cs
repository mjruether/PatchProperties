using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableUInt : IPatchProperty<uint?>
    {
        public uint? Value { get; set; }
    }
}
