using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }

        public Producto() { }

        public Producto(int id, string nombre, string categoria, decimal precio, int stock, string proveedor)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Precio = precio;
            this.Stock = stock;
            this.Proveedor = proveedor;
        }
    }
}