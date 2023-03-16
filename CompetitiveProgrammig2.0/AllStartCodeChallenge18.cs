namespace CompetitiveProgrammig2
{
    public class AllStartCodeChallenge18
    {
        public int StrCount(string str, char letter)
        {
            int result = new int();

            foreach (char index in str)
            {
                if (index == letter)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
