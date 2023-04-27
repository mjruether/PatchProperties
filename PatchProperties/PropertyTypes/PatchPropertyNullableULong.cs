using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableULong : IPatchProperty<ulong?>
    {
        public ulong? Value { get; set; }
    }
}
