using MediatR;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;

namespace Taxonomia.Domain.DominioEntity.Interfaces
{
    public interface IDominioHandler : 
        IRequestHandler<DominioAddCommand, DominioResult>,
        IRequestHandler<DominioUpdateCommand, DominioResult>,
        IRequestHandler<DominioDeleteCommand, DominioResult>
    {
    }
}
