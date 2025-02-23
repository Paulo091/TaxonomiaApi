namespace Taxonomia.Domain.ReinoEntity
{
    public class Dominio
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public ICollection<Reino> Reino { get; private set; }
    }
}
