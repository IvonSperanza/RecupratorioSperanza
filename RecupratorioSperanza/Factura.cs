using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class Factura
    {
        private DateTime fecha;
        private int numero;
        List<Producto> producto;
        Cliente : Cliente;         
       public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Numero { get { return numero; } set { numero = value; } }

    } }
