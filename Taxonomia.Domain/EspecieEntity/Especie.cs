using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrganismoEntity;

namespace Taxonomia.Domain.EspecieEntity
{
    public class Especie
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int GeneroId { get; private set; }
        public Genero Genero { get; private set; }
        public ICollection<Organismo> Organismo { get; private set; }
    }
}
