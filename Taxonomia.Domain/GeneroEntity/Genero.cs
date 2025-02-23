using Taxonomia.Domain.EspecieEntity;
using Taxonomia.Domain.FamiliaEntity;

namespace Taxonomia.Domain.GeneroEntity
{
    public class Genero
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int FamiliaId { get; private set; }
        public Familia Familia { get; private set; }
        public ICollection<Especie> Especie { get; private set; }
    }
}
