namespace CompetitiveProgrammig2
{
    public class ReplaceWithAlphabetPosition
    {
        public string AlphabetPosition(string text)
        {
            text = text.Replace(" ", "");
            string letras = "";

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    letras += c;
                }
            }

            letras = letras.ToUpper();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] listResult = new string[letras.Length];
            string result = "";


            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int e = 0; e < letras.Length; e++)
                {
                    if (letras[e] == alphabet[i])
                    {
                        listResult[e] = (i + 1).ToString();
                    }
                }
            }
            for (int i = 0; i < listResult.Length; i++)
            {
                if (listResult[i] != " ")
                {
                    result += listResult[i];
                    result += " ";
                }
            }

            result = result.TrimEnd();

            return result;
        }
    }
}
