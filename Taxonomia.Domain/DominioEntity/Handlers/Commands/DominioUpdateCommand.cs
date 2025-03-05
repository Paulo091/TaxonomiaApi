using MediatR;
using System.ComponentModel.DataAnnotations;
using Taxonomia.Domain.DominioEntity.DTOs;

namespace Taxonomia.Domain.DominioEntity.Handlers.Commands
{
    public class DominioUpdateCommand : IRequest<DominioResult>
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }        
    }
}
