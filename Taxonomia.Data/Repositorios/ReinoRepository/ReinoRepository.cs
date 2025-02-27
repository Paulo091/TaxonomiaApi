using Microsoft.EntityFrameworkCore;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Data.Repositorios.Base;
using Taxonomia.Domain.DominioEntity.Interfaces;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Data.Repositorios.ReinoRepository
{
    public class ReinoRepository : Repository<Reino>, IReinoRepository
    {
        public ReinoRepository(SqlContext context) : base(context) { }

        public async Task<Reino?> ObterRegistroPorId(Guid id)
            => await ObterPorId(id);

        public async Task<IEnumerable<Reino?>> ObterPorNome(string nome)
            => await Db.Reino.AsNoTracking().Where(x => x.Nome.Contains(nome)).ToListAsync();

        public async Task<IEnumerable<Reino?>> Buscar(string nome)
            => await Buscar(x => x.Id != null);
    }
}
