using MediatR;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Domain.DominioEntity.Handlers.Commands
{
    public class DominioAddCommand : IRequest<DominioResult>
    {
        public string Nome { get; set; }        
    }
}
