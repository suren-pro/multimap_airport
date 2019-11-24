using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        Dictionary<string, List<int>> multimap = new Dictionary<string, List<int>>()
        {
            ["a"] = new List<int> { 5, 4, 3, 5 },
            ["b"] = new List<int> { 5, 4, 3, 5, 78 },
            ["c"] = new List<int> { 5, 4, 3, 5, 25 },


        };

        foreach (string key in multimap.Keys)
        {
            Console.Write($"['{key}']=[");
            foreach (int  item in multimap[key])
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("]");
        }
       



    }
}
