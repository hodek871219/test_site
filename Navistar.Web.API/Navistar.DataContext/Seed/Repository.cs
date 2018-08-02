using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Navistar.Model.common;

namespace Navistar.DataContext.Seed
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext _dbContext;

        /// <summary>
        /// Constructor that receives as parameter the database context
        /// </summary>
        /// <param name="dbTaskContext">Context of the database</param>
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds asynchronously a new record to a table.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task that represents the asynchronous save operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        public async Task<int> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update asynchronously an existing record in a table.
        /// </summary>
        /// <param name="entity">Entity to be updated</param>
        /// <returns>A task that represents the asynchronous update operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        public async Task<int> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes asynchronously an existing record from a table
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        /// <returns>A task that represents the asynchronous delete operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        public async Task<int> DeleteAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            return await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets asynchronously a record from a table.
        /// </summary>
        /// <param name="id">Identifier of the entity to be obtained</param>
        /// <returns>A task that represents the asynchronous get operation.
        /// The task result contains the entity obtained from the database.
        /// </returns>
        public async Task<T> GetAsync(Guid id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        /// <summary>
        /// Gets asynchronously all the records in a table.
        /// </summary>
        /// <returns>A task that represents the asynchronous get all operation.
        /// The task result contains the list of existing records in the table.
        /// </returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().Take(10).ToListAsync();
        }

        /// <summary>
        /// Gets asynchronously all the records that satisfy the expression of the filter
        /// </summary>
        /// <param name="filter">Expression with entity filters</param>
        /// <returns>A task that represents the asynchronous get filtered operation.
        /// The task result contains the list of records that compliment the filter.
        /// </returns>
        public async Task<IEnumerable<T>> GetFiltered(Expression<Func<T, bool>> filter)
        {
            var result = _dbContext.Set<T>().Where(filter);
            return await result.ToListAsync();
        }
    }
}
