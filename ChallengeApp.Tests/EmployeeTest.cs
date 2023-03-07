namespace ChallengeApp.Tests
{
    public class Tests
    {
        

        [Test]
        public void WhenEmployye3AddScore_ShouldResultSum()
        {
            //arrange
            var employee3 = new Employee("Adam ", "Kaminski",21);

            employee3.AddScore(5);
            employee3.AddScore(8);
            employee3.AddScore(6);
            employee3.AddScore(5);
            employee3.AddScore(-9);

            //act
            var result =employee3.Result;

            //assert
            Assert.AreEqual(15, result);
        }
    }
}