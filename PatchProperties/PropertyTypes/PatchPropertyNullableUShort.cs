
using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableUShort : IPatchProperty<ushort?>
    {
        public ushort? Value { get; set; }
    }
}
