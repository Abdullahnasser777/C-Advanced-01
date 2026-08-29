using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__02
{
        public class Container<T>
        {
            private T _Item;
            public void Add(T Item) => _Item = Item;

            public T Get() => _Item;

        
        }
}
