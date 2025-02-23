using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.FiloEntity
{
    public class Filo : Entity
    {
        public string Nome { get; private set; }
        public Guid ReinoId { get; private set; }
        public Reino Reino { get; private set; }
        public ICollection<Classe> Classe { get; private set; }
    }
}
