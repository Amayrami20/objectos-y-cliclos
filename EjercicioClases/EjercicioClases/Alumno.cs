using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Edad { get; set; }
        public string Matricula { get; set; }


        public Alumno() { }



        public Alumno(int id, String nombre, string apellidoP, string apellidoM, int edad, string matricula)
        {

            this.Id = id;
            this.Nombre = nombre;
            this.ApellidoP = apellidoP;
            this.ApellidoM = apellidoM;
            this.Edad = edad;
            this.Matricula = matricula;

        }




    }
}
