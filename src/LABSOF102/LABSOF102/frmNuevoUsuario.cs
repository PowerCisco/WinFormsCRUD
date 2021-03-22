using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABSOF102
{

    public partial class frmNuevoUsuario : Form
    {
        private void LimpiarFormulario()
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCarrera.Clear();
        }

        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este botón aún no funciona.", "Función no implementada.");
        }
    }
}
