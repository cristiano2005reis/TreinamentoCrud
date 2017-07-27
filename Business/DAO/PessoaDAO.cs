using Business.Context;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DAO
{
    public class PessoaDAO:GenericDAO<Pessoa>
    {
        private CadastroContext context;
        
        public Pessoa FindByName(string name)
        {
            return context.Set<Pessoa>().Find(name);
        }
    }
}
