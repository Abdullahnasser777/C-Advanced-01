using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__07
{
    public class valueCalculator<T> where T : struct
    {
        public T value { get; set; }
        public valueCalculator(T value) => value = value;
    }
}
