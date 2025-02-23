using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.FamiliaEntity;

namespace Taxonomia.Domain.OrdemEntity
{
    public class Ordem
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int ClasseId { get; private set; }
        public Classe Classe { get; private set; }
        public ICollection<Familia> Familia { get; private set; }
    }

}
