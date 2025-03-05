using AutoMapper;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;

namespace Taxonomia.Data.Mapper
{
    public class DominioProfile : Profile
    {
        public DominioProfile()
        {
            CreateMap<Dominio, DominioResult>();
            CreateMap<DominioAddCommand, Dominio>();
            CreateMap<DominioUpdateCommand, Dominio>();
            CreateMap<DominioDeleteCommand, Dominio>();
        }
    }
}
