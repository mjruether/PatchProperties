using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyFloat : IPatchProperty<float>
    {
        public float Value { get; set; }
    }
}
