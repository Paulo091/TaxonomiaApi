using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.EspecieEntity;

namespace Taxonomia.Domain.OrganismoEntity
{
    public class Organismo : Entity
    {        
        public string NomeCientifico { get; private set; }
        public string NomeComum { get; private set; }
        public string Descricao { get; private set; }
        public Guid EspecieId { get; private set; }
        public Especie Especie { get; private set; }
    }
}
