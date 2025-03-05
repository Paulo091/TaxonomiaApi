using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.FamiliaEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.OrdemEntity
{
    public class Ordem : TaxonomiaBaseEntity
    {        
        public Guid ClasseId { get; private set; }
        public Classe Classe { get; private set; }
        public ICollection<Familia> Familia { get; private set; }
    }

}
