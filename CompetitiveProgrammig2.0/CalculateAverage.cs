using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammig2
{
    internal class CalculateAverage
    {
        public double FindAverage(double[] array)
        {
            double result = 0;

            if (array.Length > 0)
            {
                foreach (var item in array)
                {
                    result += item;
                }

                return result / array.Length;
            }

            return 0;
        }
    }
}
