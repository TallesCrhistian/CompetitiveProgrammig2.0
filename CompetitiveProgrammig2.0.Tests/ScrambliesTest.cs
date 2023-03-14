namespace CompetitiveProgrammig2.Tests
{
    public class ScrambliesTest
    {
        Scramblies _scrambliesTest;

        [SetUp]
        public void SetUp()
        {
            _scrambliesTest = new Scramblies();
        }

        [TestCase("rkqodlw", "world")]
        [TestCase("cedewaraaossoqqyt", "codewars")]
        [TestCase("scriptingjava", "javascript")]
        [TestCase("scriptsjava", "javascripts")]
        [TestCase("aabbcamaomsccdd","commas")]
        [TestCase("commas", "commas")]
        [TestCase("sammoc", "commas")]
        public void Scramble_CheckStingTrue(string str1, string str2)
        {
            bool result = _scrambliesTest.Scramble(str1, str2);

            Assert.IsTrue(result);
        }

        [TestCase("katas", "steak")]
        [TestCase("scriptjavx", "javascript")]
        [TestCase("javscripts", "javascript")]
        public void Scramble_CheckStingFalse(string str1, string str2)
        {
            bool result = _scrambliesTest.Scramble(str1, str2);

            Assert.IsFalse(result);
        }
    }
}
