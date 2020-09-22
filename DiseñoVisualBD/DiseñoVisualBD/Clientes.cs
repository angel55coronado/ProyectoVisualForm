using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiseñoVisualBD
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (true)//Este True es un "Por mientras"
            {
                //Aquí va el codigo de la conexion y el guardado
                LabelDeGuardadoExitoso.Visible = true;
            }
        }
    }
}
