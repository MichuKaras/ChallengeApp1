namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeScorePoints()
        {
            // arrange
            var user = new User("Jeży", "Killer");
            user.AddScore(2);
            user.AddScore(-7);
            user.AddScore(3);
            user.AddScore(6);
            user.AddScore(7);
            user.AddScore(-4);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(7, result);
        }
    }
}