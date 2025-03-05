using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrdemEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.FamiliaEntity
{
    public class Familia : TaxonomiaBaseEntity
    {       
        public Guid OrdemId { get; private set; }
        public Ordem Ordem { get; private set; }
        public ICollection<Genero> Genero { get; private set; }
    }
}
