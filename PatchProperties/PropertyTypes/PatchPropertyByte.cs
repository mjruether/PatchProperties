using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyByte : IPatchProperty<byte>
    {
        public byte Value { get; set; }
    }
}
