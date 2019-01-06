using GG.CadastroClientesDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Repository
{
    public interface IRepositoryRead<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetPaginate(int skip, int take);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
