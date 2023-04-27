using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertySByte : IPatchProperty<sbyte>
    {
        public sbyte Value { get; set; }
    }
}
