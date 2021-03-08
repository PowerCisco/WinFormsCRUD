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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Close();
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //estudiantes.Add(new Estudiante() { Nombre = "Francisco", Apellido = "Castillo", Asignatura = "SOF102", Creditos = 3, Matricula = "2020-0533" }
            
            
            dataGridView1.DataSource = estudiantes;

        }
    }
}
