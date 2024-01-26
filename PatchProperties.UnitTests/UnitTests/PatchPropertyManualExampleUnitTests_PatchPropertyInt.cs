using PatchProperties.PropertyTypes;
using PatchProperties.UnitTests.Infrastructure.TestEntities;
using PatchProperties.UnitTests.Infrastructure.TestPatchModels;

namespace PatchProperties.UnitTests
{
    [TestClass]
    public class PatchPropertyManualExampleUnitTests_PatchPropertyInt
    {
        /// <summary>
        /// Demonstrates how to use the set of Patch Property classes to apply updates in an effiecient manner.
        /// The alternative is to use the PatchPropertiesServices.SetValues(), which uses reflection to set the values
        /// and will be slower than the manual approach.
        /// </summary>
        [TestMethod]
        public void PatchInt_NonNullProperty_ManuallyChecked_SetValue()
        {
            int newValue = 1;

            var entityToUpdate = new PatchableEntity(); // Likely pulled from database.
            
            var patchModel = new IntPatchModel()
            {
                SomeInt = new PatchPropertyInt()
                {
                    Value = newValue
                }
            };

            Assert.AreNotEqual(newValue, entityToUpdate.SomeInt);

            if (patchModel.SomeInt is not null)
            {
                entityToUpdate.SomeInt = patchModel.SomeInt.Value;
            }

            Assert.AreEqual(newValue, entityToUpdate.SomeInt);
        }

        [TestMethod]
        public void PatchInt_NullProperty_ManuallyChecked_DontSetValue()
        {
            int newValue = 1;

            var entityToUpdate = new PatchableEntity(); Assert.AreNotEqual(newValue, entityToUpdate.SomeInt);

            var patchModel = new IntPatchModel()
            {
                // SomeInt property is not set, and therefore null on the incoming request model.
                //SomeInt = new PatchPropertyInt()
                //{
                //    Value = newValue
                //}
            };

            Assert.AreNotEqual(newValue, entityToUpdate.SomeInt);

            if (patchModel.SomeInt is not null)
            {
                entityToUpdate.SomeInt = patchModel.SomeInt.Value;
            }

            Assert.AreNotEqual(newValue, entityToUpdate.SomeInt);
        }
    }
}