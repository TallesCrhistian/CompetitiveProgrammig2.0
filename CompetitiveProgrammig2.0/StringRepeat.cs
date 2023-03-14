namespace CompetitiveProgrammig2
{
    public class StringRepeat
    {
        public string RepeatStr(int n, string s)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += s;
            }

            return result;
        }
    }
}
