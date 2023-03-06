namespace CompetitiveProgrammig2
{
    public class BuildPileOfCubes
    {
        public long findNb(long m)
        {
            long result = 0;

            for (int i = 1; i < m; i++)
            {
                double last = Math.Pow(i, 3);

                m = m - (long)last;

                result++;
            }

            if (m > 0 || m < 0)
            {
                return -1;
            }

            return result;
        }
    }
}

