using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectolistbox
{
    public partial class proyectlistbox : Form
    {
        public proyectlistbox()
        {
            InitializeComponent();
        }

        private void proyectlistbox_Load(object sender, EventArgs e)
        {

        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (mostrarlistbox.SelectedIndex != -1)
                mostrarlistbox.Items.RemoveAt(mostrarlistbox.SelectedIndex);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarlistbox.Items.Add(entradatextbox.Text);
            entradatextbox.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            mostrarlistbox.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
