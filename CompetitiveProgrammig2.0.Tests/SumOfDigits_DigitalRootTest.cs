using CompetitiveProgrammig2;

namespace CompetitiveProgrammig2.Tests
{
    public class SumOfDigits_DigitalRootTest
    {
        SumOfDigits_DigitalRoot _sumOfDigits_Digital;

        [SetUp]
        public void Setup()
        {
            _sumOfDigits_Digital = new SumOfDigits_DigitalRoot();
        }

        [TestCase(0, 0)]
        [TestCase(10, 1)]
        [TestCase(16, 7)]
        [TestCase(195, 6)]
        [TestCase(992, 2)]
        [TestCase(167346, 9)]
        [TestCase(999999999999, 9)]
        public void Test1(long n, int expectedResult)
        {
            int result = _sumOfDigits_Digital.DigitalRoot(n);

            Assert.That(result == expectedResult);
        }
    }
}