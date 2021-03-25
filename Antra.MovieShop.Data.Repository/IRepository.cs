using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MovieShop.Data.Repository
{
    public interface IRepository<T>where T:class

    {
        void Insert(T item);
        public T GetByName(string name);
        public  IEnumerable<T> GetAll();
        T GetById(int id);
        
    }
}
