using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<AirPort> keys = new SortedSet<AirPort>(new SortBySize())
            {
                new AirPort{ Name="nDSAD",CountryCode = "SSSD44",Size=Sizes.Large},
                new AirPort{ Name="nDSAeeeeeee",CountryCode = "SSD445454",Size=Sizes.Medium},
                new AirPort{ Name="nDSdasdsads",CountryCode = "SSSD447888",Size=Sizes.Small},
                new AirPort{ Name="ndssddasd",CountryCode = "SSSD4WWW4",Size=Sizes.Mega},
                new AirPort{ Name="asdddddwq",CountryCode = "SWWSSD44",Size=Sizes.SuperMega},


            };

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
