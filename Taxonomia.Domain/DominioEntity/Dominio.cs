using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.DominioEntity
{
    public class Dominio
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public ICollection<Reino> Reino { get; private set; }
    }
}
