using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class Producto
    {
        private string nombre;
        private int cantidad;
        private int codigo;
        private decimal precio;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Cantidad { get {  return cantidad; } set {  cantidad = value; } }
        public int Codigo { get {  return codigo; } set {  codigo = value; } }
        public decimal Precio { get {  return precio; } set {  precio = value; } }


    }
}
