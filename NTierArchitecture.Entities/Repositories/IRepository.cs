﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Repositories;
public interface IRepository<T> where T : class
{
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    void Update(Task entity);
    void Remove(T entity);
    Task<T> GetByIdAsync(Expression< Func<T, bool> > expression, CancellationToken cancellationToken);
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
}
