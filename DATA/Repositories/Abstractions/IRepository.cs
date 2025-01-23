﻿using CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repositories.Abstractions
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
       
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> SaveChangesAsync();

    }
}