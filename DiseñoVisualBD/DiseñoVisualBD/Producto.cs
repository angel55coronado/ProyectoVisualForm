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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (true)//El true es la condicion deconexion a la BD
            {
                //Aquí va el codigo de guardado en la BD
                LabelDeGuardadoExitoso.Visible = true;
            }
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            Close();
        }
    }
}
