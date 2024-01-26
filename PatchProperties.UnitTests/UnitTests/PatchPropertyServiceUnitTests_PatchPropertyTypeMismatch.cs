using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyServiceUnitTests_PatchPropertyTypeMismatch
    {
        [TestMethod]
        public void CannotPatchMisMatchedType()
        {
            var service = new PatchPropertyService();

            string newValue = "asdf";

            var entityToUpdate = new PatchableEntity();

            var patchModel = new IntPatchModel()
            {
                MisTypedInt = new PatchPropertyString()
                {
                    Value = newValue
                }
            };

            var respone = service.SetValues(entityToUpdate, patchModel);

            Assert.AreEqual(1, respone.Warnings.Count);
            Assert.IsTrue(respone.Warnings.ContainsKey("MisTypedInt"));
        }
    }
}