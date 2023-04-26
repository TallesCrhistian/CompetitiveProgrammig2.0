using System.Numerics;

namespace CompetitiveProgrammig2
{
    public class Power_of_2
    {
        public BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n + 1];
            int index = 0;

            for (int i = 0; i < n + 1; i++)
            {
                result[index] = (BigInteger)Math.Pow(2 , i);
                index++;
            }

            return result;

        }

    }
}
