using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T Get(int itemId);
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
    }
}
