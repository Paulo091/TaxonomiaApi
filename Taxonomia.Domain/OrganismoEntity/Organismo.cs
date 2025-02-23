using Taxonomia.Domain.EspecieEntity;

namespace Taxonomia.Domain.OrganismoEntity
{
    public class Organismo
    {
        public int Id { get; private set; }
        public string NomeCientifico { get; private set; }
        public string NomeComum { get; private set; }
        public string Descricao { get; private set; }
        public int EspecieId { get; private set; }
        public Especie Especie { get; private set; }
    }
}
