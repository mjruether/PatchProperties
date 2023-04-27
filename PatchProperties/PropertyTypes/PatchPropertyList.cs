using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyList<T> : IPatchProperty<List<T>?>
    {
        public List<T>? Value { get; set; }
    }
}
