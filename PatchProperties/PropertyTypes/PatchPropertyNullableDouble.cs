using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableDouble : IPatchProperty<double?>
    {
        public double? Value { get; set; }
    }
}
