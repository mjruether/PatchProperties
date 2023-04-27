using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableSByte : IPatchProperty<sbyte?>
    {
        public sbyte? Value { get; set; }
    }
}
