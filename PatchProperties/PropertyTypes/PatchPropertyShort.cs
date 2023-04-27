using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyShort : IPatchProperty<short>
    {
        public short Value { get; set; }
    }
}
