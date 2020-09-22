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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProveedoresButton_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            
        }

        private void ProductoButton_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
        }
    }
}
