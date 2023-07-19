using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class RepositorioFactura : Interfas
    {
        private List<Factura> facturaList;
        private List<Producto> productos;
        public RepositorioFactura()
        {
            facturaList = new List<Factura>();
        }
        public Factura Buscar(string parametro)
        {
            return facturaList.FirstOrDefault(elemento => elemento.productos.ToLower() == parametro.ToLower());
        }
        public string EliminarFactura(string facturaList)
        {
            var encontrarfactura = Buscar(facturaList);
            if (facturaList == null)
            {
                return "La factura no existe.";
            }
            else
            {
                encontrarfactura.Remove(facturaList);
                return "La factura se eliminó correctamente.";
            }

        }
        public ReadOnlyCollection<Factura> ListarFactura()
        {
            return facturaList.AsReadOnly();
        }

        public decimal Total
        {
            get
            {
                decimal Total = 0;
                foreach (var kvp in Subtotal, int Cantidad)
                {
                    Total += kvp.Key.Subtotal * kvp.Cantidad;
                }
                return Total;
            }

        }
    }
}