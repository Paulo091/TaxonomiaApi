using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrganismoEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.EspecieEntity
{
    public class Especie : TaxonomiaBaseEntity
    {                
        public Guid GeneroId { get; private set; }
        public Genero Genero { get; private set; }
        public ICollection<Organismo> Organismo { get; private set; }
    }
}
