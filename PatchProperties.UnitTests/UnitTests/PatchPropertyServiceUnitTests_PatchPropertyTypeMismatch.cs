using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyServiceUnitTests_PatchPropertyTypeMismatch
    {
        [TestMethod]
        public void CanPatchInt()
        {
            var service = new PatchPropertyService();

            int newValue = 1;

            var entityToUpdate = new PatchableEntity();
            
            var patchModel = new IntPatchModel()
            {
                SomeInt = new PatchPropertyInt()
                {
                    Value = newValue
                }
            };

            Assert.AreNotEqual(newValue, entityToUpdate.SomeInt);

            service.SetValues(entityToUpdate, patchModel);

            Assert.AreEqual(newValue, entityToUpdate.SomeInt);
        }

        [TestMethod]
        public void CannotPatchMisMatchType()
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