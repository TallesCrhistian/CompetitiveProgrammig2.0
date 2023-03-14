namespace CompetitiveProgrammig2
{
    public class BeginnerSeries2Clock
    {
        public int Past(int h, int m, int s)
        {
            int result = (h * 3600000) + (m * 60000) + (s * 1000);
            return result;  
        }
    }
}
