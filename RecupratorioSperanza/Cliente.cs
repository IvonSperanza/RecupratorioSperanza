using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get {  return apellido; } set {  apellido = value; } }
        public int Dni { get {  return dni; } set {  dni = value; } }
        public int Telefono { get { return telefono; }
            set
            {
                telefono = value;
            }
           }

    }
}
