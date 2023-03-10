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
            string employee1 = ("Adamus");
            string employee3 = ("Adamus");

            //assert
            Assert.AreEqual(employee1, employee3);
        }

        [Test]
        public void GetFloatValues_ShouldReturnEquals()
        {
            //arrange
            float float1 = 8.5f;
            float float2 = 8.5f;

            //assert
            Assert.AreEqual(float1, float2);
        }
    }
}
