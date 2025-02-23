using Taxonomia.Domain.Base.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Interfaces
{
    public interface IDominioRepository : IRepository<Dominio>
    {
        Task<IEnumerable<Dominio?>> ObterPorNome(string nome);
    }
}
