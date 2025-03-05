using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.OrdemEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.ClasseEntity
{
    public class Classe : TaxonomiaBaseEntity
    {        
        public Guid FiloId { get; private set; }
        public Filo Filo { get; private set; }
        public ICollection<Ordem> Ordem { get; private set; }
    }
}
