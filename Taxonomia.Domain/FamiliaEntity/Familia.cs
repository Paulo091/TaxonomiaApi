using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrdemEntity;

namespace Taxonomia.Domain.FamiliaEntity
{
    public class Familia : Entity
    {       
        public string Nome { get; private set; }
        public Guid OrdemId { get; private set; }
        public Ordem Ordem { get; private set; }
        public ICollection<Genero> Genero { get; private set; }
    }
}
