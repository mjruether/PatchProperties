using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyString : IPatchProperty<string>
    {
        public string? Value { get; set; }
    }
}
