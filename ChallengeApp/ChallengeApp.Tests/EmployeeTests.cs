namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestForMinStats()
        {

            // arrange
            var employee = new Employee("Michał", "Karaś");
            
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade(1);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void TestForMaxStats()
        {
            var employee = new Employee("Michał", "Karaś");

            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(3);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void TestForAverageStats()
        {
            var employee = new Employee("Michał", "Karaś");

            employee.AddGrade(9);
            employee.AddGrade(6);    
            employee.AddGrade(4);
            employee.AddGrade(6);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5.4f, statistics.Average);
        }
    }
}
