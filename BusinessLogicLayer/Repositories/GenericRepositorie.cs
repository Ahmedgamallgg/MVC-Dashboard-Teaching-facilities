using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class GenericRepositorie<T> : IGenericRepositorie<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _Context;

        public GenericRepositorie(ApplicationDbContext context)
        {
            _Context = context;
        }
        public int Add(T entity)
        {
            _Context.Set<T>().Add(entity);
            return _Context.SaveChanges();
        }

        public int Delete(T entity)
        {
            _Context.Set<T>().Remove(entity);
            return _Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
            => _Context.Set<T>().ToList();

        public T GetById(int? id)
            => _Context.Set<T>().FirstOrDefault(e => e.Id == id);

        public int Update(T entity)
        {
            _Context.Set<T>().Update(entity);
            return _Context.SaveChanges();
        }
    }
}
