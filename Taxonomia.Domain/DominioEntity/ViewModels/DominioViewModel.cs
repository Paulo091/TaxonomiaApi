using System.ComponentModel.DataAnnotations;

namespace Taxonomia.Domain.DominioEntity.DTOs
{
    public class DominioViewModel
    {
        [Required]
        public int Ids { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string teste { get; set; }
    }
}
