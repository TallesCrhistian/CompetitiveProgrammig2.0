namespace CompetitiveProgrammig2
{
    public class HighestAndLowest
    {
        public string HighAndLow(string numbers)
        {
            List<string> listNumbers = new List<string>();
            List<int> listInt = new List<int>();
            string result;

            listNumbers.AddRange(numbers.Split(' '));
            listInt = listNumbers.ConvertAll(int.Parse);

            listInt.Sort();

            result = listInt[listInt.Count - 1].ToString() + " ";
            result += listInt[0].ToString();

            return result;
        }
    }
}
