using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.DominioEntity
{
    public class Dominio : Entity
    {
        public string Nome { get; private set; }
        public ICollection<Reino> Reino { get; private set; }
    }
}
