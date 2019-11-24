using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class SortBySize:IComparer<AirPort>
    {
        public int Compare(AirPort first, AirPort second)
        {
            if (Convert.ToInt32(first?.Size) >Convert.ToInt32(second?.Size))
            {
                return 1;
            }
            if (Convert.ToInt32(first?.Size) <Convert.ToInt32(second?.Size))
            {
                return -1;
            }
            return 0;

        }
    }
}
