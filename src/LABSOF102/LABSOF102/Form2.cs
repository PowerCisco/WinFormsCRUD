using LABSOF102.Classes;
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
    public partial class formResultados : Form
    {
        BindingList<Estudiante> estudiantes = new BindingList<Estudiante>();


        public formResultados()
        {
            estudiantes.Add(new Estudiante("Francisco", "Castillo", "2020-0533", "SOF102", 3));
            estudiantes.Add(new Estudiante("Alberto", "Martinez", "2019-0353", "INF108", 3));

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Close();
            //Form1.txtMatricula.Text = dataGridView1.
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
            DataGridViewRow row = dgvRegistro.Rows[e.RowIndex];
            Form1 form1 = new Form1();

            form1.txtNombre.Text = dgvRegistro.CurrentRow.Cells[0].Value.ToString();
            form1.txtApellido.Text = dgvRegistro.CurrentRow.Cells[1].Value.ToString();
            form1.txtMatricula.Text = dgvRegistro.CurrentRow.Cells[2].Value.ToString();
            form1.txtAsignatura.Text = dgvRegistro.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            dgvRegistro.DataSource = estudiantes;
        }
    }
}
