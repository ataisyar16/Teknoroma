using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Teknoroma.Entities.DAL.Contexts;
using Teknoroma.Entities.DAL.GenericRepository.Abstract;

namespace Teknoroma.Entities.DAL.GenericRepository.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly AppDbContext _db;
        public Repository(AppDbContext db)
        {
            this._db = db;
        }
        public virtual async Task<int> InsertAsync(T entity, CancellationToken cancellationToken)
        {
            await _db.Set<T>().AddAsync(entity, cancellationToken);
            return await _db.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            _db.Set<T>().Update(entity);
            return await _db.SaveChangesAsync(cancellationToken);
        }
        public virtual async Task<int> DeleteAsync(T entity, CancellationToken cancellationToken)
        {
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync(cancellationToken);

        }

        public virtual async Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await _db.Set<T>().FindAsync(id, cancellationToken);

        }
        public virtual async Task<ICollection<T>?> GetAllAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return _db.Set<T>().ToList();
            }
            return _db.Set<T>().Where(filter).ToList();

        }

        public virtual async Task<IQueryable<T>?> GetAllIncludeAsync(CancellationToken cancellationToken, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {

            // var result = db.GetAllInclude(p=>p.ProductName=="xyz" ,p=>p.Category,p=>Suplier);
            IQueryable<T> query;
            if (filter == null)
            {
                query = _db.Set<T>();
            }
            else
            {
                query = _db.Set<T>().Where(filter);
            }

            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public virtual async Task<T?> GetAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> filter)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(filter, cancellationToken);
        }




    }
}
