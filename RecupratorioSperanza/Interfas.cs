using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupratorioSperanza
{
    internal class Interfas
    {
        string Agregar(A item);
        string Modificar(A item);
        string Eliminar(A item);
        ReadOnlyCollection<A> Listar();
        A Buscar(string parametro);
    }
}
