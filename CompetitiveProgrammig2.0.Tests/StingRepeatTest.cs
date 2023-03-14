namespace CompetitiveProgrammig2.Tests
{
    public class StingRepeatTest
    {
        private StringRepeat _stingRepeat;

        [SetUp]
        public void SetUp()
        {
            _stingRepeat = new StringRepeat();
        }

        [TestCase("*", 3, "***")]
        public void RepeatStr_RepeatedTimes(string input, int n,string expectedResult)
        {
            string result = _stingRepeat.RepeatStr(n, input);

            Assert.That(result == expectedResult);
        }
    }
}
