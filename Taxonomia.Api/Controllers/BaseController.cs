using Microsoft.AspNetCore.Mvc;
using Taxonomia.Domain.Base.Interfaces;

namespace Taxonomia.Api.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected IActionResult CustomReturn(object? result)
        {
            if(MensagemSucessoValida())
                return Ok(new
                {
                    success = true,
                    data = _notificador.ObterMensagemSucesso()
                });
            else if (OperacaoValida() && result != null)
                return Ok(new
                {
                    success = true,
                    data = result
                });
            else if (OperacaoValida())
                return NoContent();
            else
                return BadRequest(new
                {
                    success = false,
                    errors = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
                });
        }

        protected bool OperacaoValida()
            => !_notificador.TemNotificacao();

        protected bool MensagemSucessoValida()
            => _notificador.TemMensagemSucesso();
    }
}
