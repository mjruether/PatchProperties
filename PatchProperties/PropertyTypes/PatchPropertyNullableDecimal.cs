using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableDecimal : IPatchProperty<decimal?>
    {
        public decimal? Value { get; set; }
    }
}
