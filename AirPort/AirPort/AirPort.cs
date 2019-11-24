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
        private string size_number;
       
        public string Size
        {
            get
            {
                return size_number;
            }



            set
            {
                
                switch (value)
                {
                    case "Small":
                        this.size = value;
                        this.size_number = "0";
                        break;
                    case "Medium":
                        this.size = value;
                        this.size_number = "1";
                        break;
                    case "Large":
                        this.size = value;
                        this.size_number = "2";
                        break;
                    case "Mega":
                        this.size = value;
                        this.size_number = "3";
                        break;
                    case "Super Mega":
                        this.size = value;
                        this.size_number = "4";
                        break;
                    default:
                        break;
                }

            }


        }




        public override string ToString()
        {
            return $"{Name}, {CountryCode}, {size}";
        }

        

       
    }
}
