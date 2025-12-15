using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.RepositorioDados
{
    public interface IClienteRepositorio
    {
        Cliente getCliente(int id);
    }
}
