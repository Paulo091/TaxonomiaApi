using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Services
{
    public class DominioService : IDominioService
    {
        private readonly IDominioRepository _dominioRepository;

        public DominioService(IDominioRepository dominioRepository)
        {
            _dominioRepository = dominioRepository;
        }

        public async Task<IEnumerable<Dominio?>> ObterPorNome(DominioViewModel query)
        {            
            return await _dominioRepository.Buscar(x =>
                (query.Id == Guid.Empty || x.Id == query.Id) &&
                (string.IsNullOrEmpty(query.Nome) || x.Nome.Contains(query.Nome))
            );
        }
    }
}
