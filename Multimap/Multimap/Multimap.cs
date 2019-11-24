using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimap
{
    class Multimap<T,K> : Dictionary<T, K>, IDictionary<T, K>  where K:List<int>
    {
       
      
    }
}
