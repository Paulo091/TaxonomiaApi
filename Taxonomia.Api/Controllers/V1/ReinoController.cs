using Microsoft.AspNetCore.Mvc;
using Taxonomia.Domain.ReinoEntity.DTOs;
using Taxonomia.Domain.ReinoEntity.Interfaces;

namespace Taxonomia.Api.Controllers.V1
{
    [ApiController]    
    [Route("api/v1/reino")]
    public class ReinoController : ControllerBase
    {        
        public ReinoController() {}

        [HttpGet]
        public async Task<IEnumerable<ReinoResult>> Get([FromServices] IReinoService service, [FromQuery] ReinoViewModel query)
        {
            var resultado = await service.ObterPorNome(query);
            return resultado;
        }
    }
}
