using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Handlers
{
    public class DominioHandler : IDominioHandler
    {
        public async Task<DominioResult> Handle(DominioAddCommand request, CancellationToken cancellationToken)
        {
            return new DominioResult() { Id = new Guid(), Nome = "Teste insert"};
        }
    }
}
