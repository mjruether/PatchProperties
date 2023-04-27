using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyChar : IPatchProperty<char>
    {
        public char Value { get; set; }
    }
}
