using Microsoft.AspNetCore.Mvc;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Api.Controllers.V1
{
    [ApiController]    
    [Route("api/v1/dominio")]
    public class DominioController : ControllerBase
    {
        IDominioRepository _dominioRepository;

        public DominioController(IDominioRepository dominioRepository) 
        {
            _dominioRepository = dominioRepository;
        }

        [HttpGet]
        public async Task<Dominio> Get(Guid id)
        {
            var resultado = await _dominioRepository.ObterPorId(id);
            return resultado;
        }
    }
}
