using Primer_Parcial.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrosparcial rg = new Registrosparcial();
            rg.MdiParent = this;
            rg.Show();


        }

        private void vEntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultaparcial cs = new Consultaparcial();
            cs.MdiParent = this;
            cs.Show();
        }
    }
}
