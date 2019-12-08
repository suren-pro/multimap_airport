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
            if (first.Size>second.Size)
            {
                return 1;
            }
            if (first.Size < second.Size)
            {
                return -1;
            }
            return 0;

        }
    }
}
