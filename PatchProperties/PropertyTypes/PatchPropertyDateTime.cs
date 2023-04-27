using PatchProperties.PropertyTypes.Contracts;

namespace PatchProperties.PropertyTypes
{
    public class PatchPropertyDateTime : IPatchProperty<DateTime>
    {
        public DateTime Value { get; set; }
    }
}
