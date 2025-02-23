using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.OrdemEntity;

namespace Taxonomia.Domain.ClasseEntity
{
    public class Classe : Entity
    {
        public string Nome { get; private set; }
        public Guid FiloId { get; private set; }
        public Filo Filo { get; private set; }
        public ICollection<Ordem> Ordem { get; private set; }
    }
}
