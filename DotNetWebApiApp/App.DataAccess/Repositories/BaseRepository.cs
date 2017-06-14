using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using App.DomainModels;
using App.DataAccess.Interfaces;

namespace App.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #region Properties 
        public AppDataContext Context
        {
            get;
            protected set;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Retrieves an entity based on ID
        /// </summary>
        /// <param name="id">Id of the entity to match</param>
        /// <returns>Entity with matching identifier</returns>
        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }
        /// <summary>
        /// Retrieves all entities
        /// </summary>
        /// <returns>All entities available in the repository</returns>
        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }
        /// <summary>
        /// Adds or updates an existing entity
        /// </summary>
        /// <param name="entity">Entity to add/update</param>
        public void AddOrUpdate(T entity)
        {
            // Assuming that new entity always has ID as zero
            Context.Entry(entity).State = ((BaseEntity)entity).Id == 0 ? EntityState.Added : EntityState.Modified;
        }

        /// <summary>
        /// Updates only the selected properties of an entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <param name="propertyExpression">Properties to update as lambda expressions</param>
        public void Update(T entity, params Expression<Func<T, object>>[] propertyExpressions)
        {
            Context.Configuration.ValidateOnSaveEnabled = false;
            Context.Set<T>().Attach(entity);
            var entry = Context.Entry(entity);
            //Iterate and mark the requested properties as modified
            foreach (var expression in propertyExpressions)
            {
                entry.Property(expression).IsModified = true;
            }
        }
        // <summary>
        /// Removes an entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
        /// <summary>
        /// Save all changes made to the repository
        /// </summary>
        public void Save()
        {
            Context.SaveChanges();
        }
        #endregion
    }
}
