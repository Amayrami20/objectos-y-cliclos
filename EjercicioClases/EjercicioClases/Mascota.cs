using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Tipo de mascota (Perro, Gato, Etc)
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }

        public Mascota() { }

        public Mascota(int id, string nombre, string tipo, int edad, string raza, string color)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Edad = edad;
            this.Raza = raza;
            this.Color = color;
        }
    }
}
