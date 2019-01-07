using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.Interfaces.Repository;
using GG.CadastroClientesDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GG.CadastroClientesDDD.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepositoryRead<TEntity>, IRepositoryWrite<TEntity> where TEntity : Entity, new()
    {
        protected CadastroClientesDDDContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new CadastroClientesDDDContext();
            DbSet = Db.Set<TEntity>();
        }

        //Write

        public TEntity Add(TEntity entity)
        {
            var obj = DbSet.Add(entity);
            SaveChanges();

            return obj;
        }

        public TEntity Update(TEntity entity)
        {
            var entry = Db.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
            SaveChanges();

            return entity;
        }

        public void Remove(Guid id)
        {
            var entity = GetById(id);
            DbSet.Remove(entity);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        //Read

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> GetPaginate(int skip, int take)
        {
            return DbSet.Skip(skip).Take(take).ToList();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
