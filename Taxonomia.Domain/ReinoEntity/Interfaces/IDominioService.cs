using Taxonomia.Domain.ReinoEntity.DTOs;

namespace Taxonomia.Domain.ReinoEntity.Interfaces
{
    public interface IReinoService
    {
        Task<IEnumerable<ReinoResult?>> ObterPorNome(ReinoViewModel query);
    }
}
