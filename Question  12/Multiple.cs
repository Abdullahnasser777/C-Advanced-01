using C__Advanced.Question__11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__12
{
    public class AdvancedHandler<T> where T : Entity, IComparable<T>, new()
    {
        public T CreateAndCompare(T item)
        {
            T newItem = new T();
            return item.CompareTo(newItem) > 0 ? item : newItem;
        }
    }
}
