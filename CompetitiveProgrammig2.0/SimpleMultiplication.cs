namespace CompetitiveProgrammig2
{
    internal class SimpleMultiplication
    {
        public int Multiply(int x)
        {
            if (x % 2 == 0)
            {
                return x * 8;
            }
            else
            {
                return x * 9;
            }

        }
    }
}
