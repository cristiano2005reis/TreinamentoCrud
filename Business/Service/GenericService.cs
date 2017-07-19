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
        private CadastroContext context;

        public void Add(T entity)
        {
            using (GenericDAO<T> dao = new GenericDAO<T>())
            {
                dao.Add(entity);
            }   
        }

        public void Update(T entity)
        {
            using (GenericDAO<T> dao = new GenericDAO<T>())
            {
                dao.Update(entity);
            }
        }

        public void Delete(T entity)
        {
            using (GenericDAO<T> dao = new GenericDAO<T>())
            {
                dao.Delete(entity);
            }
        }

        public void Find(int id)
        {
            using (GenericDAO<T> dao = new GenericDAO<T>())
            {
                dao.Find(id);
            }
        }

        public List<T> ListAll()
        {
            using (GenericDAO<T> dao = new GenericDAO<T>())
            {
                List<T> list = new List<T>();
                return list = dao.ListAll().ToList();
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
