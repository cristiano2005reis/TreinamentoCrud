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

            StringBuilder errors = new StringBuilder();

            if (!string.IsNullOrEmpty(entity.Nome))
            {
                errors.Append("O campo nome é obrigatório \n");
            }

            if (!string.IsNullOrEmpty(entity.CPF))
            {
                errors.Append("O campo CPF é obrigatório \n");
            }


            if (!string.IsNullOrEmpty(errors.ToString()))
            {
                throw new Exception(errors.ToString());
            }

        }

    }
}
