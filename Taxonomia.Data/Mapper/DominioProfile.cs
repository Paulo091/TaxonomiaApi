using AutoMapper;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.DominioEntity.DTOs;

namespace Taxonomia.Data.Mapper
{
    public class DominioProfile : Profile
    {
        public DominioProfile()
        {
            CreateMap<Dominio, DominioResult>();
        }
    }
}
