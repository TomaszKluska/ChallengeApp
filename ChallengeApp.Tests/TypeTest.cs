using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void GetIntValues_ShouldReturnEquals()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetStringValues_ShouldReturnEquals()
        {
            //arrange
            string employee1 = ("Jan");
            string employee3 = ("Adam");

            //assert
            Assert.AreNotEqual(employee1, employee3);
        }

        [Test]
        public void GetFloatValues_ShouldReturnEquals()
        {
            //arrange
            float float1 = 7.4f;
            float float2 = 7.4f;

            //assert
            Assert.AreEqual(float1, float2);

            
        }
    }
}
