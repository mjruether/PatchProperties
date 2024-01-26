using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyServiceUnitTests_PatchPropertyNameMismatch
    {
        [TestMethod]
        public void CannotPatchMisMatchedName()
        {
            var service = new PatchPropertyService();

            int newValue = 1;

            var entityToUpdate = new PatchableEntity();

            var patchModel = new MisNamedPatchModel()
            {
                MisNamedInt = new PatchPropertyInt()
                {
                    Value = newValue
                }
            };

            var respone = service.SetValues(entityToUpdate, patchModel);

            Assert.AreEqual(1, respone.Warnings.Count);
            Assert.IsTrue(respone.Warnings.ContainsKey("MisNamedInt"));
        }
    }
}