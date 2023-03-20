
using NUnit.Framework;


namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        

        [Test]
        public void WhenEmployye3AddScore_ShouldResultSum()
        {
            //arrange
            var employee3 = new Employee("Adam ", "Kaminski", 21);

            employee3.AddScore(5);
            employee3.AddScore(8);
            employee3.AddScore(6);
          //  employee3.AddScore(5);
           // employee3.AddScore(-9);

            //act
            var statistics = employee3.GetStatistics();


            //assert
            Assert.AreEqual(Math.Round(6.33, 2), Math.Round(statistics.Average, 2));
           
        }
    }
}