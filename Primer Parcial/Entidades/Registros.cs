using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    public class Registros
    {
        [Key]
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaVencimiento { get; set; }

        public Registros()
        {
            ID = 0;
            Cantidad = 0;
            Precio = 0;
            Nombre = " ";
            fechaVencimiento = DateTime.Now;
        }
    }
}
