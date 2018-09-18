using Primer_Parcial.DAL.Scripts;
using Primer_Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.BLL
{
   public class VendedorBLL
    {
        public static bool Guardar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.vendedorbl.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(vendedor).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                var eliminar = contexto.vendedorbl.Find(id);
                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;

        }

        public static Vendedor Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Vendedor vendedor = new Vendedor();

            try
            {
                vendedor = contexto.vendedorbl.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vendedor;
        }

    }
}
