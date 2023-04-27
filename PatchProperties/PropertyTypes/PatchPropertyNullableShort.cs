using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableShort : IPatchProperty<short?>
    {
        public short? Value { get; set; }
    }
}
