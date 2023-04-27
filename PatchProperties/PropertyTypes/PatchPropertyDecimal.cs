using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyDecimal : IPatchProperty<decimal>
    {
        public decimal Value { get; set; }
    }
}
