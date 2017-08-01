﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DAO;

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
            if (string.IsNullOrEmpty(entity.Nome))
            {
                throw new Exception("Nome não informado!");
            }

            if (string.IsNullOrEmpty(entity.CPF))
            {
                throw new Exception("CPF não informado!");
            }

        }

    }
}
