using Microsoft.AspNetCore.Mvc;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Api.Controllers.V1
{
    [ApiController]    
    [Route("api/v1/dominio")]
    public class DominioController : ControllerBase
    {        
        public DominioController() {}

        [HttpGet]
        public async Task<IEnumerable<DominioResult>> Get([FromServices] IDominioService service, [FromQuery] DominioViewModel query)
        {
            var resultado = await service.ObterPorNome(query);
            return resultado;
        }
    }
}
