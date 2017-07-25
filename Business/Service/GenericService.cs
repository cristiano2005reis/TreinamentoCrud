using Business.Context;
using Business.DAO;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class GenericService<T>: IDisposable where T: GenericModel
    {
        protected readonly GenericDAO<T> dao;

        public GenericService(GenericDAO<T> dao)
        {
            this.dao = dao;
        }

        public virtual void Add(T entity)
        {
            
                dao.Add(entity);

        }

        public void Update(T entity)
        {

                dao.Update(entity);

        }

        public void Delete(T entity)
        {

                dao.Delete(entity);

        }

        public void Find(int id)
        {

                dao.Find(id);

        }

        public IEnumerable<T> ListAll()
        {

                List<T> list = new List<T>();
                return list = dao.ListAll().ToList();

        }

        public void Dispose()
        {

        }
    }
}
