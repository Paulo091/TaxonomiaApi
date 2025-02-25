using Microsoft.EntityFrameworkCore;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Data.Repositorios.Base;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Data.Repositorios.DominioRepository
{
    public class DominioRepository : Repository<Dominio>, IDominioRepository
    {
        public DominioRepository(SqlContext context) : base(context) { }

        public async Task<Dominio?> ObterRegistroPorId(Guid id)
            => await ObterPorId(id);

        public async Task<IEnumerable<Dominio?>> ObterPorNome(string nome)
            => await Db.Dominio.AsNoTracking().Where(x => x.Nome.Contains(nome)).ToListAsync();

        public async Task<IEnumerable<Dominio?>> Buscar(string nome)
            => await Buscar(x => x.Id != null);
    }
}
