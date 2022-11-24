using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Single
    {
        
        
        public static readonly Single Instance = new Single();
        private Single() { }

      
        
    }
  

}

