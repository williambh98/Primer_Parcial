using Primer_Parcial.BLL;
using Primer_Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial.UI
{
    public partial class Registrosparcial : Form
    {
        public Registrosparcial()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;
            RetecnumericUpDown.Value = 0;
            errorProvider.Clear();
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Vendedor LlenarClase()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.VendedorID = Convert.ToInt32(IDnumericUpDown.Value);
            vendedor.Nombre = NombretextBox.Text;
            vendedor.Sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            vendedor.Restencion = Convert.ToDecimal(RetencionnumericUpDown.Value);
            vendedor.Restencion = Convert.ToDecimal(RetecnumericUpDown.Value);
            return vendedor;
        }

        private void LlenarCampo(Vendedor vendedor)
        {
            IDnumericUpDown.Value = vendedor.VendedorID;
            NombretextBox.Text = vendedor.Nombre;
            SueldonumericUpDown.Value = vendedor.Sueldo;
            RetencionnumericUpDown.Value = vendedor.Restencion;
            RetecnumericUpDown.Value = vendedor.Restecionp;
        }


        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;
            
            if (RetecnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(RetecnumericUpDown, "Ingre Porciento retencion");
                paso = false;
            }
            
            if (RetencionnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(RetencionnumericUpDown, "Ingre Retencion");
                paso = false;
            }
            if (SueldonumericUpDown.Value <= 0)
            {
                errorProvider.SetError(SueldonumericUpDown, "Digite Sueldo");
            }
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Ingre Nombre");
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Vendedor vendedor = VendedorBLL.Buscar((int)IDnumericUpDown.Value);
            return (vendedor != null);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            Vendedor vendedor = new Vendedor();
            int.TryParse(IDnumericUpDown.Text, out id);

            if (vendedor != null)
            {

                MessageBox.Show("Encontrado");
                LlenarCampo(vendedor);
            }
            else
            {
                MessageBox.Show("No se encontro");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Vendedor vendedor;
            bool paso = false;
            if (!Validar())
                return;
            vendedor = LlenarClase();
            if (IDnumericUpDown.Value == 0)
                paso = VendedorBLL.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede  modificar un campo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = VendedorBLL.Modificar(vendedor);
            }
            if (paso)
            {
                MessageBox.Show("Guardado con Existo");
                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo");
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
          {
            errorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se Encuetra en la base de datos");
                return;

            }
            if (VendedorBLL.Eliminar(id))
            {
                MessageBox.Show("Se Elimino existosamente", "Existo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
          }


        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal Porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            Porciento /= 100;
            decimal reticion = sueldo * Porciento;
            RetecnumericUpDown.Value = reticion;

        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal sueldo = Convert.ToDecimal(SueldonumericUpDown.Value);
            decimal Porciento = Convert.ToDecimal(RetencionnumericUpDown.Value);
            Porciento /= 100;
            decimal reticion = sueldo * Porciento;
            SueldonumericUpDown.Value = reticion;

        }
    }


}



