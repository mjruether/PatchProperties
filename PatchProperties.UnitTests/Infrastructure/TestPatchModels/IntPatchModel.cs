using PatchProperties.PropertyTypes;

namespace PatchProperties.UnitTests.Infrastructure.TestPatchModels
{
    public class IntPatchModel
    {
        public PatchPropertyInt? SomeInt { get; set; }

        public PatchPropertyString? MisTypedInt { get; set; }
    }
}
