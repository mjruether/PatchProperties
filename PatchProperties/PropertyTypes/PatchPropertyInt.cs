using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyInt : IPatchProperty<int>
    {
        public int Value { get; set; }
    }
}
