namespace CompetitiveProgrammig2
{
    public class TwoSum
    {
        public int[] TwoSumMethod(int[] numbers, int target)
        {         
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int e = 1; e < numbers.Length; e++)
                {
                    if (numbers[i] + numbers[e] == target)
                    {
                        return new int[]  {i, e };
                    }
                }
            }

            return new int[0];
        }
    }
}
