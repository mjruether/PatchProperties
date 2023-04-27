using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyServiceUnitTests
    {
        [TestMethod]
        public void CanPatchInt()
        {
            var service = new PatchPropertyService();

            int newValue = 1;

            var entityToUpdate = new PatchableEntity();
            
            var patchModel = new PatchModel()
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
    }
}