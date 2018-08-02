using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Navistar.Model.common;

namespace Navistar.DataContext.Seed
{
    public interface IRepository<T> where T:Entity
    {
        /// <summary>
        /// Adds asynchronously a new record to a table.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task that represents the asynchronous save operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        Task<int> AddAsync(T entity);

        /// <summary>
        /// Update asynchronously an existing record in a table.
        /// </summary>
        /// <param name="entity">Entity to be updated</param>
        /// <returns>A task that represents the asynchronous update operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        Task<int> UpdateAsync(T entity);

        /// <summary>
        /// Deletes asynchronously an existing record from a table
        /// </summary>
        /// <param name="entity">The entity to delete</param>
        /// <returns>A task that represents the asynchronous delete operation.
        /// The task result contains the number of state entries written to the database.
        /// </returns>
        Task<int> DeleteAsync(T entity);

        /// <summary>
        /// Gets asynchronously a record from a table.
        /// </summary>
        /// <param name="id">Identifier of the entity to be obtained</param>
        /// <returns>A task that represents the asynchronous get operation.
        /// The task result contains the entity obtained from the database.
        /// </returns>
        Task<T> GetAsync(Guid id);

        /// <summary>
        /// Gets asynchronously all the records in a table.
        /// </summary>
        /// <returns>A task that represents the asynchronous get all operation.
        /// The task result contains the list of existing records in the table.
        /// </returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Gets asynchronously all the records that satisfy the expression of the filter
        /// </summary>
        /// <param name="filter">Expression with entity filters</param>
        /// <returns>A task that represents the asynchronous get filtered operation.
        /// The task result contains the list of records that compliment the filter.
        /// </returns>
        Task<IEnumerable<T>> GetFiltered(Expression<Func<T, bool>> filter);
    }
}

