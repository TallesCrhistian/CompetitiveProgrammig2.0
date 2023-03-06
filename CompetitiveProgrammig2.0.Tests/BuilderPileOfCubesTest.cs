namespace CompetitiveProgrammig2.Tests
{
    public class BuilderPileOfCubesTest
    {
        BuildPileOfCubes _buildPileOfCubes;   

        [SetUp]
        public void SetUp()
        {
            _buildPileOfCubes= new BuildPileOfCubes();
        }

        [TestCase(4183059834009, 2022)]
        [TestCase(24723578342962, -1)]
        public void FindNb(long m, long expectedResult)
        {
            long result = _buildPileOfCubes.findNb(m);

            Assert.That(expectedResult == result);
        }
    }
}
