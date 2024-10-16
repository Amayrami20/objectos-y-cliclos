using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjercicioClases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cuadro de 3x3\n\n");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }




            List<Alumno> alumnos = new List<Alumno>();
            List<Mascota> mascotas = new List<Mascota>();
            List<Profesor> profesores = new List<Profesor>();
            List<Producto> productos = new List<Producto>();
            List<Cancion> canciones = new List<Cancion>();
            


            for (int i = 0; i < 5; i++)
            {

                alumnos.Add(new Alumno(i, $"Nombre {i}", $"ApellidoP {i}", $"ApellidoM {i}", 20 + i, $"Matricula {i}"));
                mascotas.Add(new Mascota(i + 1, $"Mascota {i}", $"Perro {i}", i + 1, $"Raza {i}", $"Color {i}"));
                profesores.Add(new Profesor(i + 1, $"Profesor {i}", $"Apellido {i}", $"Materia {i}", 30 + i, $"Plantel {i}"));
                productos.Add(new Producto(i + 1, $"Producto {i}", $"Categoria {i}", 10.5m * (i + 1), 100 - (i * 10), $"Proveedor {i}"));
                canciones.Add(new Cancion(i + 1, $"Cancion {i}", $"Artista {i}", $"Album {i}", 180 + (i * 10), $"Genero {i}"));
            }


            Console.WriteLine("\n\n\nAlumnos:");
            Console.WriteLine(JsonConvert.SerializeObject(alumnos, Newtonsoft.Json.Formatting.Indented));
            Console.WriteLine("\n\n\nMascotas:");
            Console.WriteLine(JsonConvert.SerializeObject(mascotas, Newtonsoft.Json.Formatting.Indented));
            Console.WriteLine("\n\n\nProfesores:");
            Console.WriteLine(JsonConvert.SerializeObject(profesores, Newtonsoft.Json.Formatting.Indented));
            Console.WriteLine("\n\n\nProductos:");
            Console.WriteLine(JsonConvert.SerializeObject(productos, Newtonsoft.Json.Formatting.Indented));
            Console.WriteLine("\n\n\nCanciones:");
            Console.WriteLine(JsonConvert.SerializeObject(canciones, Newtonsoft.Json.Formatting.Indented));


            string jsonAlumnos = JsonConvert.SerializeObject(alumnos);
            string jsonMascota = JsonConvert.SerializeObject(mascotas);
            string jsonProfesor = JsonConvert.SerializeObject(profesores);
            string jsonProducto = JsonConvert.SerializeObject(productos);
            string jsonCancion = JsonConvert.SerializeObject(canciones);
            
            
            Console.ReadKey();
        }
    }
}
