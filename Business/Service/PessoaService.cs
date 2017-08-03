using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DAO;
using System.Reflection;

namespace Business.Service
{
    public class PessoaService:GenericService<Pessoa>
    {
        public PessoaService():base(new PessoaDAO())
        {
                
        }

        public Pessoa Find(string name)
        {
            PessoaDAO pessoaDao = (PessoaDAO)dao;
            return pessoaDao.FindByName(name);
        }

        public override void Validade(Pessoa entity)
        {
            Type atributos = typeof(Pessoa);

            PropertyInfo[] valores = atributos.GetProperties();

            object str = null;

            foreach(PropertyInfo valor in valores)
            {
                str = valor.GetValue(entity, null);

                if(str == null)
                {
                    throw new Exception();
                }
            }

        }

    }
}
