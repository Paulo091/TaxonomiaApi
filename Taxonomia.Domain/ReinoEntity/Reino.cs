using Taxonomia.Domain.FiloEntity;

namespace Taxonomia.Domain.ReinoEntity
{
    public class Reino
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Dominio DominioId { get; private set; }
        public Dominio Dominio { get; private set; }
        public ICollection<Filo> Filo { get; private set; }
    }
}
