using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableLong : IPatchProperty<long?>
    {
        public long? Value { get; set; }
    }
}
