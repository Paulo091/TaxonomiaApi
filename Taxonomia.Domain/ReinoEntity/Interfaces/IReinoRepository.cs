using Taxonomia.Domain.Base.Interfaces;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.DominioEntity.Interfaces
{
    public interface IReinoRepository : IRepository<Reino>
    {
        Task<IEnumerable<Reino?>> ObterPorNome(string nome);
    }
}
