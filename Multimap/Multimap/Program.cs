using System;
using System.Collections.Generic;



namespace Multimap
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Multimap<int, string> map = new Multimap<int, string>();
            map.Addmap(1, "s");
            map.Addmap(1, "a");
            map.Addmap(1, "b");
            map.Addmap(1, "s");
            map.Addmap(1, "dasd");
            map.Addmap(1, "s");
            map.Addmap(2, "Suren");
            map.Addmap(2, "Scorpion");
            map.Addmap(2, "November");




            map.Show(1);
            map.Show(2);
        }
    }
}