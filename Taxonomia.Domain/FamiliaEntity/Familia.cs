using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrdemEntity;

namespace Taxonomia.Domain.FamiliaEntity
{
    public class Familia
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int OrdemId { get; private set; }
        public Ordem Ordem { get; private set; }
        public ICollection<Genero> Genero { get; private set; }
    }
}
