namespace CompetitiveProgrammig2
{
    public class FindOutWhetherTheShapeIsCube
    {
        public bool IsCube(double volume, double side)
        {

            double length = volume / (side * side);

            if (length == side && length > 0)
            {
                return true;
            }

            return false;
        }
    }
}
