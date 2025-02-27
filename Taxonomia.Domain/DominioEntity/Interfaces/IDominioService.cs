using Taxonomia.Domain.DominioEntity.DTOs;

namespace Taxonomia.Domain.DominioEntity.Interfaces
{
    public interface IDominioService
    {
        Task<IEnumerable<DominioResult?>> ObterPorNome(DominioViewModel query);
    }
}
