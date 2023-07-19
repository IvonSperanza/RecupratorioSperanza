using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class RepositorioProducto : Interfas
    {
        private List<Producto> productos;
        public RepositorioProducto()
        {
            productos = new List<Producto>();
            productos.Add(new Producto() { Nombre = "Lavandina", Cantidad = 1, Codigo = 1234, Precio = 4 });
            productos.Add(new Producto() { Nombre = "Jabon", Cantidad = 2, Codigo = 1235, Precio = 6 });
        }

        public decimal Subtotal
        {
            get
            {
                decimal Subtotal = 0;
                foreach (var kvp in productos)
                {
                    Subtotal += kvp.Key.precio * kvp.value;
                }
                return Subtotal;
            }

        }
        public decimal Total => Subtotal;

        public Producto Buscar(string parametro)
        {
            return productos.FirstOrDefault(elemento => elemento.productos.ToLower() == parametro.ToLower());
        }
        public string Agregar(Producto item)
            {
                if (item is null) return "Error al agregar";
                var productoencontrado = Buscar(item.productos);
                if (productoencontrado == null)
                {
                    productos.Add(item);
                    return "Se agregó correctamente.";
                }
                else return "Ya existe";
            }


        public ReadOnlyCollection<Producto> ListarProducto()
        {
            return productos.AsReadOnly();
        }

    }
}
