using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyUShort : IPatchProperty<ushort>
    {
        public ushort Value { get; set; }
    }
}
