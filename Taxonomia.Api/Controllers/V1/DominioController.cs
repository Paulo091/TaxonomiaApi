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
        public async Task<IActionResult> Get([FromServices] IDominioService service, [FromQuery] DominioViewModel query)
        {
            var resultado = await service.ObterPorNome(query);
            return CustomReturn(resultado);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IDominioHandler handler, [FromBody] DominioAddCommand command)
        {
            var resultado = await handler.Handle(command, new CancellationToken());
            return CustomReturn(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromServices] IDominioHandler handler, [FromBody] DominioUpdateCommand command)
        {
            var resultado = await handler.Handle(command, new CancellationToken());
            return CustomReturn(resultado);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Put([FromServices] IDominioHandler handler, [FromRoute] DominioDeleteCommand command)
        {
            var resultado = await handler.Handle(command, new CancellationToken());
            return CustomReturn(resultado);
        }
    }
}
