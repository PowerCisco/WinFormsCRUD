using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSOF102.Classes
{
    class Estudiante
    {


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }
        public string Asignatura { get; set; }
        public int Creditos { get; set; }

        private Dictionary<string, int> Notas;

        public Estudiante(string nombre, string apellido, string matricula, string asignatura, int creditos)
        {
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
            Asignatura = asignatura;
            Creditos = creditos;

            Notas = new Dictionary<string, int>();
            Notas.Add("PrimerParcial", 0);
            Notas.Add("SegundoParcial", 0);
            Notas.Add("ExamenFinal", 0);
            Notas.Add("Laboratorio", 0);
            Notas.Add("Practicas", 0);
            Notas.Add("Total", 0);

        }

    }
}
