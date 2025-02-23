using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.OrdemEntity;

namespace Taxonomia.Domain.ClasseEntity
{
    public class Classe
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int FiloId { get; private set; }
        public Filo Filo { get; private set; }
        public ICollection<Ordem> Ordem { get; private set; }
    }
}
