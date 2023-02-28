using System.Drawing;

namespace CompetitiveProgrammig2
{
    public class SumOfDigits_DigitalRoot
    {
        public int DigitalRoot(long n)
        {
            long soma = 0;
            long result = 0;
            long resultfinally = 0;

            while (n > 0)
            {
                soma += n % 10;
                n /= 10;
            }

            if (soma <= 9)
            {
                return (int)soma;
            }
            else
            {

                while (soma > 0)
                {

                    result += soma % 10;
                    soma /= 10;
                }

                if (result <= 9)
                {
                    return (int)result;
                }
                else
                {
                    while (result > 0)
                    {

                        resultfinally += result % 10;
                        result /= 10;
                    }
                }
            }

            return (int)resultfinally;

        }
    }
}
