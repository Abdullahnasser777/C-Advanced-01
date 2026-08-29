using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Question__11
{
    public class Entity 
    { public int Id { get; set; } }
    public class EntityManager<T> where T : Entity
    {
        public void PrintID(T entity) => Console.WriteLine($"Entity ID :{entity.Id}");
    }
    public class User : Entity { }
}
