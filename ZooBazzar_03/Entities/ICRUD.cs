using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/ICRUD.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/ICRUD.cs
{
    public interface ICRUD<T>
    {
        public void Add(T obj);
        public List<T> Read();
        public void Update(int id, T obj);
        public void Delete(int id);
    }
}
