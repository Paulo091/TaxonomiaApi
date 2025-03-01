using Taxonomia.Domain.Base.Notificacoes;

namespace Taxonomia.Domain.Base.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void AddNotificacao(string mensagem);
    }
}
