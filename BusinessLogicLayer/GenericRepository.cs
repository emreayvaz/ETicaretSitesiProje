using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        Context db = new Context();

        public void Delete(int itemId)
        {
            T silinecek = db.Set<T>().Find(itemId);
            db.Set<T>().Remove(silinecek);
            db.SaveChanges();
        }

        public T Get(int itemId)
        {
            return db.Set<T>().Find(itemId);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void Update(T item)
        {
            db.Set<T>().Attach(item);
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
