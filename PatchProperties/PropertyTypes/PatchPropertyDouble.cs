using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyDouble : IPatchProperty<double>
    {
        public double Value { get; set; }
    }
}
