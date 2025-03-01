using Microsoft.AspNetCore.Mvc;
using Taxonomia.Domain.Base.Interfaces;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Api.Controllers.V1
{
    [ApiController]    
    [Route("api/v1/[controller]")]
    public class DominioController : BaseController
    {        
        public DominioController(INotificador notificador) : base(notificador)  { }
        
        [HttpGet]
        public async Task<IActionResult> Teste([FromServices] IDominioService service, [FromQuery] DominioViewModel query)
        {
            var resultado = await service.ObterPorNome(query);
            return Response(resultado);
        }
        
        [HttpPost]
        public async Task<DominioResult> Post([FromServices] IDominioHandler handler, [FromBody] DominioAddCommand command)
        {
            var resultado = await handler.Handle(command, new CancellationToken());
            return resultado;
        }
    }
}
