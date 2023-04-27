using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyULong : IPatchProperty<ulong>
    {
        public ulong Value { get; set; }
    }
}
