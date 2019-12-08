using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class AirPort
        
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        private string size;
 
       
        public Sizes Size { get; set; }
       




        public override string ToString()
        {
            switch (Size)
            {
                case Sizes.Small:
                    this.size = "Small";

                    break;
                case Sizes.Medium:
                    this.size = "Medium";

                    break;
                case Sizes.Large:
                    this.size = "Large";


                    break;
                case Sizes.Mega:
                    this.size = "Mega";

                    break;
                case Sizes.SuperMega:
                    this.size = "SuperMega";

                    break;
                default:
                    break;
            }
            return $"{Name}, {CountryCode}, {size}";
        }

        

       
    }
}
