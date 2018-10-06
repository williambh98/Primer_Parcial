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
    public partial class Consultaparcial : Form
    {
        public Consultaparcial()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
            var listado = new List<Vendedor>();
            if(CristeriotextBox.Text.Trim().Length > 0)
                {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = VendedorBLL.GetList(p => true);
                        break;
                    case 1:
                         int id = Convert.ToInt32(CristeriotextBox.Text);
                         listado = VendedorBLL.GetList(p => p.VendedorID == id);
                        break;
                    case 2:
                        listado = VendedorBLL.GetList(p => p.Nombre.Contains(CristeriotextBox.Text));
                        break;
                    case 3:
                        decimal sueldo = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = VendedorBLL.GetList(p => p.Sueldo == sueldo);
                        break;
                    case 4:
                        decimal retencion = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = VendedorBLL.GetList(p => p.Restencion == retencion);
                        break;
                    case 5:
                        decimal retencionp = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = VendedorBLL.GetList(p => p.Restecionp == retencionp);
                        break;
                }
                listado = listado.Where(c => c.FechaVendedor.Date >= DesdedateTimePicker.Value.Date && c.FechaVendedor.Date <= HastadateTimePicker.Value.Date).ToList();

            }
            else
            {
                listado = VendedorBLL.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }

    
        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if(Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }catch(Exception )
            {
                throw;
            }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
