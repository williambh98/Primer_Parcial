using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    public class Vendedor
    {
        [Key]
        public int VendedorID { get; set; }
        public decimal Restencion { get; set; }
        public decimal Restecionp { get; set; }
        public decimal Sueldo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVendedor { get; set; }
      

        public Vendedor()
        {
            VendedorID = 0;
            Restencion = 0;
            Sueldo = 0;
            Nombre = string.Empty;
            FechaVendedor = DateTime.Now.Date;
        }
    }
}
