using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__08
{
    public class RefernceManager < T > where T : class
    {
    public bool IsNull(T item)=> item == null;
    
    }
}
