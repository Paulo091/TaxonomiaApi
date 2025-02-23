using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.FiloEntity
{
    public class Filo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int ReinoId { get; private set; }
        public Reino Reino { get; private set; }
        public ICollection<Classe> Classe { get; private set; }
    }
}
