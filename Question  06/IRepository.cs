using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__06
{
    public interface IRepository <T>
     {
      void Add (T entity);
        T GetByID(int id);
        List<T> GetAll();
    
    }
}
