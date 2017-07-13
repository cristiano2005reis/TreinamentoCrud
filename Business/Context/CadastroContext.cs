using Business.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Context
{
    public class CadastroContext : DbContext
    { 
        public CadastroContext() : base("TreinamentoCrud")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
