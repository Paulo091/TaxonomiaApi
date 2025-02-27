﻿using AutoMapper;
using Taxonomia.Domain.DominioEntity.DTOs;
using Taxonomia.Domain.DominioEntity.Interfaces;

namespace Taxonomia.Domain.DominioEntity.Services
{
    public class DominioService : IDominioService
    {
        private readonly IDominioRepository _dominioRepository;
        private readonly IMapper _mapper;

        public DominioService(IDominioRepository dominioRepository, IMapper mapper)
        {
            _dominioRepository = dominioRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DominioResult?>> ObterPorNome(DominioViewModel query)
        {            
            var resultado = await _dominioRepository.Buscar(x =>
                (query.Id == Guid.Empty || x.Id == query.Id) &&
                (string.IsNullOrEmpty(query.Nome) || x.Nome.Contains(query.Nome))
            );

            return _mapper.Map<IEnumerable<DominioResult>>(resultado);
        }
    }
}
