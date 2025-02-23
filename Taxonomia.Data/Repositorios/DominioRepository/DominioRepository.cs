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

        public async Task<Dominio?> ObterPorId(Guid id)
            => await Db.Dominio.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<Dominio?>> ObterPorNome(string nome)
            => await Db.Dominio.AsNoTracking().Where(x => x.Nome.Contains(nome)).ToListAsync();
    }
}
