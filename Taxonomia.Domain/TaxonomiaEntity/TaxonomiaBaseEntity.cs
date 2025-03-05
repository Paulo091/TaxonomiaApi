using Taxonomia.Domain.Base.Models;

namespace Taxonomia.Domain.TaxonomiaEntity
{
    public class TaxonomiaBaseEntity : Entity
    { 
        public TaxonomiaBaseEntity(){ }
        public TaxonomiaBaseEntity(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }        
    }
}
