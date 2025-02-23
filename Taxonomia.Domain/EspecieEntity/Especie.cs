using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrganismoEntity;

namespace Taxonomia.Domain.EspecieEntity
{
    public class Especie : Entity
    {        
        public string Nome { get; private set; }
        public Guid GeneroId { get; private set; }
        public Genero Genero { get; private set; }
        public ICollection<Organismo> Organismo { get; private set; }
    }
}
