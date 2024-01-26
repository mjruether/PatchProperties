using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyServiceUnitTests_PatchPropertyInt
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
        public void CanPatchNullableInt()
        {
            var service = new PatchPropertyService();

            int newValue = 1;

            var entityToUpdate = new PatchableEntity();

            var patchModel = new IntPatchModel()
            {
                SomeNullableInt = new PatchPropertyNullableInt()
                {
                    Value = newValue
                }
            };

            Assert.AreNotEqual(newValue, entityToUpdate.SomeNullableInt);

            service.SetValues(entityToUpdate, patchModel);

            Assert.AreEqual(newValue, entityToUpdate.SomeNullableInt);
        }

        [TestMethod]
        public void CanPatchNullableInt_ToNullValue()
        {
            var service = new PatchPropertyService();

            int? newValue = null;

            var entityToUpdate = new PatchableEntity()
            {
                SomeNullableInt = 0
            };

            var patchModel = new IntPatchModel()
            {
                SomeNullableInt = new PatchPropertyNullableInt()
                {
                    Value = newValue
                }
            };

            Assert.AreNotEqual(newValue, entityToUpdate.SomeNullableInt);

            service.SetValues(entityToUpdate, patchModel);

            Assert.AreEqual(newValue, entityToUpdate.SomeNullableInt);
        }
    }
}