using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public int Duracion { get; set; }
        public string Genero { get; set; }

        public Cancion() { }

        public Cancion(int id, string titulo, string artista, string album, int duracion, string genero)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Artista = artista;
            this.Album = album;
            this.Duracion = duracion;
            this.Genero = genero;
        }
    }
}