namespace CompetitiveProgrammig2
{
    public class FindNearestSquareNumber
    {
        public int NearestSq(int n)
        {
            double squade = Math.Sqrt(n);
            double resultOne = 0;
            double resultTwo = 0;

            if (squade != Math.Round(squade))
            {
                for (int i = 0; i < n; i++)
                {
                    double squadeOne = Math.Sqrt(i + n);

                    if (squadeOne == Math.Round(squadeOne))
                    {
                        resultOne = squadeOne;
                        break;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    double squadeTwo = Math.Sqrt(n - i);

                    if (squadeTwo == Math.Round(squadeTwo))
                    {
                        resultTwo = squadeTwo;
                        break;
                    }
                }
            }

            double calculateOne = Math.Pow(resultOne, 2);
            double calculateTwo = Math.Pow(resultTwo, 2);

            if (Math.Abs(calculateOne - n) < Math.Abs(calculateTwo -n))
            {
                return (int)calculateOne;
            }
            else if (Math.Abs(calculateOne - n) > Math.Abs(calculateTwo - n))
            {
                return (int)calculateTwo;
            }

            return n;
        }
    }
}
