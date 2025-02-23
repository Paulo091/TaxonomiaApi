using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.FiloEntity;

namespace Taxonomia.Domain.ReinoEntity
{
    public class Reino : Entity
    {
        public string Nome { get; private set; }
        public Guid DominioId { get; private set; }
        public Dominio Dominio { get; private set; }
        public ICollection<Filo> Filo { get; private set; }
    }
}
