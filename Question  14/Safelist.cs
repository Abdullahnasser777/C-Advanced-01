using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__14
{
    public class SafeList<T>
    {
        private readonly List<T> _list = new List<T>();
        public void Add(T item) => _list.Add(item);
        public T GetAt(int index)
        {
            if (index < 0 || index >= _list.Count)
            {
                return default!;
            }
            return _list[index];
        }
    }
}
