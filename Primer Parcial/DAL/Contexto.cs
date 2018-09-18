using Primer_Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.DAL.Scripts
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedor> vendedorbl { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
