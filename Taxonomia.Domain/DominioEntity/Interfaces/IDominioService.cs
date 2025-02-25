using Taxonomia.Domain.DominioEntity.DTOs;

namespace Taxonomia.Domain.DominioEntity.Interfaces
{
    public interface IDominioService
    {
        Task<IEnumerable<Dominio?>> ObterPorNome(DominioViewModel query);
    }
}
