using AutoMapper;
using Taxonomia.Domain.Base.Interfaces;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Services
{
    public class DominioService : IDominioService
    {
        private readonly IDominioRepository _dominioRepository;
        private readonly IMapper _mapper;
        private readonly INotificador _notificador;

        public DominioService(IDominioRepository dominioRepository, IMapper mapper, INotificador notificador)
        {
            _dominioRepository = dominioRepository;
            _mapper = mapper;
            _notificador = notificador;
        }

        public async Task<IEnumerable<DominioResult?>?> ObterPorNome(DominioViewModel query)
        {
            if (!string.IsNullOrEmpty(query.Nome) && query.Nome.Length < 4)
            {
                _notificador.AddNotificacao("O Nome deve ter pelo menos 4 caracteres");
                return null;
            }

            var resultado = await _dominioRepository.Buscar(x =>
                (query.Id == Guid.Empty || x.Id == query.Id) &&
                (string.IsNullOrEmpty(query.Nome) || x.Nome.Contains(query.Nome))
            );

            return _mapper.Map<IEnumerable<DominioResult>>(resultado);
        }
    }
}
