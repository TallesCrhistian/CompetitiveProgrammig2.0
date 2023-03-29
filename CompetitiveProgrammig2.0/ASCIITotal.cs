using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace CompetitiveProgrammig2
{
    public class ASCIITotal
    {
        public int UniTotal(string str)
        {
            ulong result = 0;

            byte[] asciiValues = Encoding.ASCII.GetBytes(str);

            for (int i = 0; i < asciiValues.Length; i++)
            {
                result += asciiValues[i];
            }

            return (int)result;
        }
    }
}
