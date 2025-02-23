using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.EspecieEntity;
using Taxonomia.Domain.FamiliaEntity;

namespace Taxonomia.Domain.GeneroEntity
{
    public class Genero : Entity
    {
        public string Nome { get; private set; }
        public Guid FamiliaId { get; private set; }
        public Familia Familia { get; private set; }
        public ICollection<Especie> Especie { get; private set; }
    }
}
