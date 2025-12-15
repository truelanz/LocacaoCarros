using AutoMapper;
using Dados.Models;
using Negocio.Models;
using Negocio.RepositorioDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly IMapper _mapper;

        public ClienteRepositorio(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Cliente getCliente(int id)
        {
            ClienteDataModel clienteDM = new ClienteDataModel();

            //logica de acesso a dados.

            //mapear        <obj destino<(<objOrigem>)
            return _mapper.Map<Cliente>(clienteDM);
        }
    }
}
