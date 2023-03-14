namespace CompetitiveProgrammig2.Tests
{
    public class BeginnerSeries2ClockTest
    {
        BeginnerSeries2Clock _beginnerSeries2Clock;

        [SetUp]
        public void SetUp()
        { 
            _beginnerSeries2Clock= new BeginnerSeries2Clock();
        }

        [TestCase(0, 1, 1, 61000)]
        public void Past_Milliseconds(int h, int m, int s, int expectedResult) 
        {
            int result = _beginnerSeries2Clock.Past(h, m, s);

            Assert.That(result == expectedResult);
        }
    }
}
