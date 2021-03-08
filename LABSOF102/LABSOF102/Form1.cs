using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using LABSOF102.Classes;

namespace LABSOF102
{
    public partial class Form1 : Form
    {



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
                    Convert.ToInt32(txtPrimerParcial.Text) +
                    Convert.ToInt32(txtSegundoParcial.Text) +
                    Convert.ToInt32(txtLaboratorio.Text) +
                    Convert.ToInt32(txtPracticas.Text) + 
                    Convert.ToInt32(txtExamenFinal.Text);
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {

            formResultados formResultados = new formResultados();
            formResultados.StartPosition = FormStartPosition.CenterParent;
            formResultados.ShowDialog();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            txtNotaFinal.Text = CalcularNota().ToString();
            txtLiteral.Text = CalcularLiteral().ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
