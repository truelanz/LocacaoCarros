using AutoMapper;
using Dados.Models;
using LocacaoCarros.Models;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;

namespace LocacaoCarros.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteDataModel>().ReverseMap();
        }
    }
}
