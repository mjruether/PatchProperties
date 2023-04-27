using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyNullableChar : IPatchProperty<char?>
    {
        public char? Value { get; set; }
    }
}
