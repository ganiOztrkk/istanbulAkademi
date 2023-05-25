using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusApi.DataAccsessLayer.Abstract;
using AkademiPlusApi.DataAccsessLayer.Concrete;
using AkademiPlusApi.EntityLayer.Concrete;

namespace AkademiPlusApi.DataAccsessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T: class, IEntity, new()
    {
        private readonly Context _context = new Context();
        public void Insert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
