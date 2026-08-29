using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__05
{
    public static class MethHelpers
    {
        public static T FindMax<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) > 0 ? a : b;
            
    
}
}
