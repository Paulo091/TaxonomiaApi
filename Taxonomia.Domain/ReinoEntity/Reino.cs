using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.ReinoEntity
{
    public class Reino : TaxonomiaBaseEntity
    {
        public Reino() { }

        public Reino(string nome) : base(nome)
        { }

        public Guid DominioId { get; private set; }
        public Dominio Dominio { get; private set; }
        public ICollection<Filo> Filo { get; private set; }
    }
}
