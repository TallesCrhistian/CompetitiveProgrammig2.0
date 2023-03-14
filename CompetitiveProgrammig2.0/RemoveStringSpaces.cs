namespace CompetitiveProgrammig2
{
    public class RemoveStringSpaces
    {
        public string NoSpace(string input)
        {
            string result = string.Empty;

            foreach (char c in input)
            {
                if (c != ' ')
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
