namespace CompetitiveProgrammig2
{
    public class ListFiltering
    {
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> intsOnly = new List<int>();
            IEnumerable<int> result;

            foreach (object item in listOfItems)
            {
                if (item is int)
                {
                    intsOnly.Add((int)item);
                }
            }

            result = intsOnly;

            return result;
        }
    }
}
