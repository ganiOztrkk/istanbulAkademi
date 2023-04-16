using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;

namespace RentACar.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Insert(T t)
        {

            _object.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }
    }
}
