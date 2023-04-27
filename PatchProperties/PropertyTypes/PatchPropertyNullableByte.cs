using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableByte : IPatchProperty<byte?>
    {
        public byte? Value { get; set; }
    }
}
