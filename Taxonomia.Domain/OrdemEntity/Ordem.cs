using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.FamiliaEntity;

namespace Taxonomia.Domain.OrdemEntity
{
    public class Ordem : Entity
    {
        public string Nome { get; private set; }
        public Guid ClasseId { get; private set; }
        public Classe Classe { get; private set; }
        public ICollection<Familia> Familia { get; private set; }
    }

}
