using GG.CadastroClientesDDD.Domain.Entities;
using System;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Repository
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(Guid id);
        int SaveChanges();
    }
}
