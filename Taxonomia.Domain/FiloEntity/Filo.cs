using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.ReinoEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.FiloEntity
{
    public class Filo : TaxonomiaBaseEntity
    {
        public Guid ReinoId { get; private set; }
        public Reino Reino { get; private set; }
        public ICollection<Classe> Classe { get; private set; }
    }
}
