using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyUInt : IPatchProperty<uint>
    {
        public uint Value { get; set; }
    }
}
