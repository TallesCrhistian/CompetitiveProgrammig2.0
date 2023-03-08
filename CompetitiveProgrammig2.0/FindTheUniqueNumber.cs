namespace CompetitiveProgrammig2
{
    public class FindTheUniqueNumber
    {
        public int GetUnique(IEnumerable<int> numbers)
        {
            List<int> listInt = numbers.ToList();
            listInt.Sort();

            if (listInt[0] != listInt[1])
            {
                return listInt[0];
            }

            else
            {
                return listInt[listInt.Count - 1];
            }           
        }
    }
}
