namespace CompetitiveProgrammig2.Tests
{
    public class ReplaceWithAlphabetPositionTest
    {
        ReplaceWithAlphabetPosition _replaceWithAlphabetPosition;

        [SetUp]
        public void SetUp()
        {
            _replaceWithAlphabetPosition = new ReplaceWithAlphabetPosition();
        }

        [Test]
        public void AphabetPosition()
        {
            string text = "The sunset sets at twelve o' clock.";
            string expectedResult = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11";

            string result = _replaceWithAlphabetPosition.AlphabetPosition(text);

            Assert.That(expectedResult == result);
        }
    }
}
