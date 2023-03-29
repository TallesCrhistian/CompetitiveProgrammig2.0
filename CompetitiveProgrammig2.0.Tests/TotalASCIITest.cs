namespace CompetitiveProgrammig2.Tests
{
    public class TotalASCIITest
    {
        ASCIITotal _aSCIITotal;

        [SetUp]
        public void SetUp()
        {
            _aSCIITotal = new ASCIITotal();
        }

        [TestCase("Mary Had A Little Lamb", 1873)]
        public void UniTotal_Translator(string str, int expectedResult)
        {
            int result = _aSCIITotal.UniTotal(str);

            Assert.That(expectedResult == result);
        }
    }
}
