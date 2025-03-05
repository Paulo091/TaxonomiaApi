using Taxonomia.Domain.ReinoEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.DominioEntity
{
    public class Dominio : TaxonomiaBaseEntity
    {
        public Dominio() { }

        public Dominio(string nome) : base(nome)
        { }

        public ICollection<Reino> Reino { get; private set; }
    }
}
