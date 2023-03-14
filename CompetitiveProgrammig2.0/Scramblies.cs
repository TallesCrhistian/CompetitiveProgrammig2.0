namespace CompetitiveProgrammig2
{
    public class Scramblies
    {
        public bool Scramble(string str1, string str2)
        {
            char[] list = str1.ToArray();
            string result = "";

            for (int i = 0; i < str2.Length; i++)
            {
                for (int e = 0; e < list.Length; e++)
                {
                    if (str2[i] == list[e])
                    {
                        result += str2[i];
                        list[e] = ' ';

                        break;
                    }
                }
            }

            if (result == str2)
            {
                return true;
            }

            return false;
        }

    }
}
