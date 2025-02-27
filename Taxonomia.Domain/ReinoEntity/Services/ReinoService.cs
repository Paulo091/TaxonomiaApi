using AutoMapper;
using Taxonomia.Domain.DominioEntity.Interfaces;
using Taxonomia.Domain.ReinoEntity.DTOs;
using Taxonomia.Domain.ReinoEntity.Interfaces;

namespace Taxonomia.Domain.ReinoEntity.Services
{
    public class ReinoService : IReinoService
    {
        private readonly IReinoRepository _dominioRepository;
        private readonly IMapper _mapper;

        public ReinoService(IReinoRepository dominioRepository, IMapper mapper)
        {
            _dominioRepository = dominioRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReinoResult?>> ObterPorNome(ReinoViewModel query)
        {            
            var resultado = await _dominioRepository.Buscar(x =>
                (query.Id == Guid.Empty || x.Id == query.Id) &&
                (string.IsNullOrEmpty(query.Nome) || x.Nome.Contains(query.Nome))
            );

            return _mapper.Map<IEnumerable<ReinoResult>>(resultado);
        }
    }
}
