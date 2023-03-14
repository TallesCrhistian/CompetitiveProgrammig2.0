namespace CompetitiveProgrammig2.Tests
{
    internal class RemoveStringSpacesTest
    {
        private RemoveStringSpaces _removeStringSpaces;

        [SetUp]
        public void SetUp()
        {
            _removeStringSpaces= new RemoveStringSpaces();  
        }

        [TestCase("8 j 8   mBliB8g  imjB8B8  jl  B", "8j8mBliB8gimjB8B8jlB")]
        public void NoSpace_RemoveSpaces(string input, string expectedResult) 
        {
            string result = _removeStringSpaces.NoSpace(input);

            Assert.That(result == expectedResult);
        }
    }
}
