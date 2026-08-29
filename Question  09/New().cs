using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__09
{
    public class Factory < T > where T : new()
    {
        public T CreateInstance() => new T();
    
    }
}
