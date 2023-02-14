namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetValuesTypeInt_ShouldReturnCorrect()
        {
            // arrange
            int number1 = 9;
            int number2 = 9;

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetReferenceTypeVar_ShouldReturnDifferent()
        {
            // arrange
            var user1 = GetUser("Jeży","Killer");
            var user2 = GetUser("Tomasz","Kammel");
            
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void GetValuesTypeDouble_ShouldReturnDifferent()
        {
            double number1 = 3.14;
            double number2 = 5.24;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetValuesTypeString_ShouldReturnCorrect()
        {
            string name1 = "Michał";
            string name2 = "Michał";

            Assert.AreEqual(name1, name2);
        }


        private User GetUser(string name, string surname)
        {
            return new User(name);
        }
    }
}
