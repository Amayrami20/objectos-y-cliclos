using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }
        public int Edad { get; set; }
        public string Plantel { get; set; }

        public Profesor() { }

        public Profesor(int id, string nombre, string apellido, string materia, int edad, string departamento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Materia = materia;
            this.Edad = edad;
            this.Plantel = departamento;
        }
    }
}