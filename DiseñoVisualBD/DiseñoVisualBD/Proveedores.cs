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
    public partial class Proveedores : Form
    {
        public Proveedores()
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
            if (true)//El true esta mientras se hace la condicion de la conexion
            {
                //Cuando se Guarden los datos se hara visible el label de datos Guardados
                LabelDatosGuardados.Visible = true;
            }
        }
    }
}
