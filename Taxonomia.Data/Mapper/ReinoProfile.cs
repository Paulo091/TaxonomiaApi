using AutoMapper;
using Taxonomia.Domain.ReinoEntity;
using Taxonomia.Domain.ReinoEntity.DTOs;

namespace Taxonomia.Data.Mapper
{
    public class ReinoProfile : Profile
    {
        public ReinoProfile()
        {
            CreateMap<Reino, ReinoResult>();
        }
    }
}
