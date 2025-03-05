using Taxonomia.Domain.Base.Interfaces;

namespace Taxonomia.Domain.Base.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        private string Mensagem {  get; set; }

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(string mensagem)
            => _notificacoes.Add(new Notificacao(mensagem));

        public List<Notificacao> ObterNotificacoes()
            => _notificacoes;

        public bool TemNotificacao()
            => _notificacoes.Any();

        public void MensagemSucesso(string mensagem)
            => Mensagem = mensagem;

        public string ObterMensagemSucesso()
            => Mensagem;

        public bool TemMensagemSucesso()
            => !string.IsNullOrEmpty(Mensagem);
    }
}
