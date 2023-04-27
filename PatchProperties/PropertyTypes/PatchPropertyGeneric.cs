using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyGeneric<T> : IPatchProperty<T?>
    {
        public T? Value { get; set; }
    }
}
