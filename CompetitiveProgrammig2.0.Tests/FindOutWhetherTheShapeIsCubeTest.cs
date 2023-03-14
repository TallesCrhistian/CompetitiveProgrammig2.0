namespace CompetitiveProgrammig2.Tests
{
    public class FindOutWhetherTheShapeIsCubeTest
    {
        private FindOutWhetherTheShapeIsCube _findOutWhetherTheShapeIsCube;

        [SetUp]
        public void SetUp()
        {
            _findOutWhetherTheShapeIsCube = new FindOutWhetherTheShapeIsCube();
        }

        [TestCase(1, 1)]
        [TestCase(8, 2)]
        public void IsCube_True(double volume, double side)
        {
            bool result = _findOutWhetherTheShapeIsCube.IsCube(volume, side);

            Assert.IsTrue(result);
        }

        [TestCase(2, 1)]
        [TestCase(6, 3)]
        public void IsCube_False(double volume, double side)
        {
            bool result = _findOutWhetherTheShapeIsCube.IsCube(volume, side);

            Assert.IsFalse(result);
        }
    }
}
