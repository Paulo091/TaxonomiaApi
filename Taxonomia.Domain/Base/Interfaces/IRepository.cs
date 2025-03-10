﻿using System.Linq.Expressions;
using Taxonomia.Domain.Base.Models;

namespace Taxonomia.Domain.Base.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task<bool> Existente(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChangesAsync();
    }
}
