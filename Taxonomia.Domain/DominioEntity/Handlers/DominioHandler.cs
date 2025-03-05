using AutoMapper;
using Taxonomia.Domain.Base.Interfaces;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Handlers
{
    public class DominioHandler : IDominioHandler
    {
        private readonly IDominioRepository _dominioRepository;
        private readonly INotificador _notificador;
        private readonly IMapper _mapper;

        public DominioHandler(IDominioRepository dominioRepository, IMapper mapper, INotificador notificador)
        {
            _notificador = notificador;
            _dominioRepository = dominioRepository;
            _mapper = mapper;
        }

        public async Task<DominioResult> Handle(DominioAddCommand request, CancellationToken cancellationToken)
        {
            var resultado = new DominioResult();
            try
            {
                var dominio = _mapper.Map<Dominio>(request);
                
                await _dominioRepository.Adicionar(dominio);

                await _dominioRepository.SaveChangesAsync();

                resultado = _mapper.Map<DominioResult>(dominio);
            }
            catch 
            {
                _notificador.AddNotificacao("Não foi possível executar a operação.");
                return null;
            }
            return resultado;
        }

        public async Task<DominioResult> Handle(DominioUpdateCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dominioExistente = await _dominioRepository.Existente(x => x.Id == request.Id);

                if(!dominioExistente)
                {
                    _notificador.AddNotificacao("O domínio informado não existe.");
                    return null;
                }

                var dominio = _mapper.Map<Dominio>(request);

                await _dominioRepository.Atualizar(dominio);

                await _dominioRepository.SaveChangesAsync();

                _notificador.MensagemSucesso("Registro Alterado com sucesso.");
            }
            catch
            {
                _notificador.AddNotificacao("Não foi possível executar a operação.");
                return null;
            }

            return null;
        }

        public async Task<DominioResult> Handle(DominioDeleteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var dominioExistente = await _dominioRepository.Existente(x => x.Id == request.Id);

                if (!dominioExistente)
                {
                    _notificador.AddNotificacao("O domínio informado não existe.");
                    return null;
                }

                await _dominioRepository.Remover(request.Id);

                await _dominioRepository.SaveChangesAsync();

                return null;
            }
            catch
            {
                _notificador.AddNotificacao("Não foi possível executar a operação.");
                return null;
            }
        }
    }
}
