using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Forgebase.Masterdata.Core.Entities;
using Forgebase.Masterdata.Core.Interfaces;
using Forgebase.Masterdata.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Forgebase.Masterdata.Infrastructure.Data
{
    public class EfRepository<T, D> : IAsyncRepository<T, D> where T : BaseEntity<D>
    {
        protected readonly ForgebaseMasterdataDbContext _dbContext;
        private readonly ILogger<EfRepository<T, D>> _logger;

        public EfRepository(ForgebaseMasterdataDbContext dbContext, ILogger<EfRepository<T, D>> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while adding entity");
            }
            return entity;
        }

        public async Task<int> CountAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.IsActive = false;
            await UpdateAsync(entity);
        }

        public async Task DeleteByIdAsync(D id)
        {
            var entity = await GetByIdAsync(id);
            await DeleteAsync(entity);
        }

        public async Task<T> GetByIdAsync(D id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByIdAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).FirstOrDefaultAsync();
        }

        public async Task<bool> IsExists(T entity, Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().AnyAsync(predicate);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().Where(e => e.IsActive).ToListAsync();
        }

        public async Task<List<T>> ListAllAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured while saving entity");
            }
            return entity;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T, D>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }
    }
}
