using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgrammig2
{
    public class CatYearsDogYears
    {
        public int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int[] years = new int[3];

            if (humanYears == 1)
            {
                years[0] = humanYears;
                years[1] = 15;
                years[2] = 15;
            }

            if (humanYears == 2)
            {
                years[0] = humanYears;
                years[1] = 24;
                years[2] = 24;
            }

            if (humanYears > 2)
            {
                years[0] = humanYears;
                years[1] = 24 + (4 * (humanYears - 2));
                years[2] += 24 + (5 * (humanYears - 2));
            }

            return years;
        }
    }
}
