using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class RepositorioCliente: Interfas
    {
       
             private List<Cliente> clientes;

        public RepositorioCliente()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Apellido = "Gonzales", Dni = 1234567, Nombre = "Maria", Telefono = 341123456 });
            clientes.Add(new Cliente() { Apellido = "Martinez", Dni = 1234568, Nombre = "Jose", Telefono = 342123456 });

        }
        public ReadOnlyCollection<Cliente> ListarCliente()
        {
            return clientes.AsReadOnly();
        }
    }
}
