using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimap
{
    class Multimap<T, K> : Dictionary<T, K>
    {

        Dictionary<T, List<K>> ms = new Dictionary<T, List<K>>();

        public void Addmap(T index,K value)
        {

            List<K> ks;

            if (!ms.TryGetValue(index,out ks))
            
                ms.Add(index, ks = new List<K>());
       
            ks.Add(value);    
       
        }
       

        public void Show(T index)
        {
            Console.Write($"{index} =[");
            foreach (var item in ms[index])
            {

                Console.Write( $"{item} ");
            }
            Console.WriteLine("]");
        }

    }
}
