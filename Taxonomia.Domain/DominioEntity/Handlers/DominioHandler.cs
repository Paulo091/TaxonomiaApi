using AutoMapper;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Handlers.Commands;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Handlers
{
    public class DominioHandler : IDominioHandler
    {
        private readonly IDominioRepository _dominioRepository;
        private readonly IMapper _mapper;

        public DominioHandler(IDominioRepository dominioRepository, IMapper mapper)
        {
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
                return null;
            }
            return resultado;
        }
    }
}
