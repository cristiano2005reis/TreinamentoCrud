using Business.Context;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DAO
{
    public class GenericDAO<T>:IDisposable where T : GenericModel
    {
        private CadastroContext context;

        public GenericDAO()
        {
            context = new CadastroContext();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public Pessoa Update (T entity)
        {            
            return null;
        }

        public void Delete (T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Find (T entity)
        {
            return context.Set<T>().Find(entity);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
