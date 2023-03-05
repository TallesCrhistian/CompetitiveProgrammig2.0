using NUnit.Framework;

namespace CompetitiveProgrammig2.Tests
{
    public class HumanReadableTimeTest
    {
        HumanReadableTime _humanReadableTime;

        [SetUp]
        public void SetUp()
        {
            _humanReadableTime = new HumanReadableTime();
        }

        [TestCase(0, "00:00:00")]
        [TestCase(5, "00:00:05")]
        [TestCase(60, "00:01:00")]
        [TestCase(86399, "23:59:59")]
        [TestCase(359999, "99:59:59")]
        public void GetReadableTime_(int seconds, string expectedResult)
        {
            string result = _humanReadableTime.GetReadableTime(seconds);

            Assert.That(expectedResult == result);
        }
    }
}
