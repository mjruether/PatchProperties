using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableDateTime : IPatchProperty<DateTime?>
    {
        public DateTime? Value { get; set; }
    }
}
