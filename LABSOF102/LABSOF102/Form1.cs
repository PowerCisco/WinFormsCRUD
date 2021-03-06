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
    public partial class Form1 : Form
    {
        public void LimpiarFormulario()
        {
            DialogResult respuesta = MessageBox.Show("¿Desea limpiar el formulario?", "Limpiar formulario", MessageBoxButtons.OKCancel);

            if (respuesta == DialogResult.OK)
            {
                txtApellido.Clear();
                txtAsignatura.Clear();
                txtCreditos.Clear();
                txtExamenFinal.Clear();
                txtLaboratorio.Clear();
                txtLiteral.Clear();
                txtMatricula.Clear();
                txtNotaFinal.Clear();
                txtPracticas.Clear();
                txtPrimerParcial.Clear();
                txtSegundoParcial.Clear();
                txtNombre.Clear();
            }
        }

        public char CalcularLiteral()
        {
            if (Convert.ToInt32(txtNotaFinal.Text) >= 90)
                return 'A';
            else if (Convert.ToInt32(txtNotaFinal.Text) >= 80 && Convert.ToInt32(txtNotaFinal.Text) < 90)
                return 'B';
            else if (Convert.ToInt32(txtNotaFinal.Text) >= 70 && Convert.ToInt32(txtNotaFinal.Text) < 80)
                return 'C';
            else
                return 'F';
        }

        public int CalcularNota()
        {
            try
            {
                return
                    txtPrimerParcial.Text.Length == 0 ? 20 : Convert.ToInt32(txtPrimerParcial.Text) +
                    txtSegundoParcial.Text.Length == 0 ? 0 : Convert.ToInt32(txtSegundoParcial.Text) +
                    txtLaboratorio.Text.Length == 0 ? 0 : Convert.ToInt32(txtLaboratorio.Text) +
                    txtPracticas.Text.Length == 0 ? 0 : Convert.ToInt32(txtPracticas.Text) +
                    txtExamenFinal.Text.Length == 0 ? 0 : Convert.ToInt32(txtExamenFinal.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Uno o más de los campos contienen datos no válidos.", "Error");
                return 0;
            }
        }

            public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("¿Desea salir de la aplicación?","Salir", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
