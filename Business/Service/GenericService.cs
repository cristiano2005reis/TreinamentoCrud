using Business.Context;
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

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
