﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Domain.Base.Interfaces;
using Taxonomia.Domain.Base.Models;

namespace Taxonomia.Data.Repositorios.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly SqlContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(SqlContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
            => await DbSet.AsNoTracking().Where(predicate).ToListAsync();

        public virtual async Task<TEntity> ObterPorId(Guid id)
            => await DbSet.FindAsync(id);

        public virtual async Task<List<TEntity>> ObterTodos()
            => await DbSet.ToListAsync();

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
            => await Db.SaveChangesAsync();

        public void Dispose()
            => Db?.Dispose();
    }
}
