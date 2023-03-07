namespace CompetitiveProgrammig2.Tests
{
    public class TwoSumTest
    {
        TwoSum _twoSum;

        [SetUp]
        public void SetUp()
        {
            _twoSum = new TwoSum();
        }

        [Test]
        public void TwoSum_Index()
        {
            int[] numbers = new int[] { 1, 2, 3 };
            int target = 4;
            int[] expectedResult = new int[] { 0, 2 };

            int[] result = _twoSum.TwoSumMethod(numbers, target);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TwoSum_Index_TestTwo()
        {
            int[] numbers = new int[] { 1234, 5678, 9012 };
            int target = 14690;
            int[] expectedResult = new int[] { 1, 2 };

            int[] result = _twoSum.TwoSumMethod(numbers, target);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TwoSum_Index_TestThree()
        {
            int[] numbers = new int[] { 2, 2, 3 };
            int target = 4;
            int[] expectedResult = new int[] { 0, 1 };

            int[] result = _twoSum.TwoSumMethod(numbers, target);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
