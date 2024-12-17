using System.Linq.Expressions;
using Teknoroma.BL.Models;
using Teknoroma.Entities.BL.Managers.Abstract;
using Teknoroma.Entities.DAL.Contexts;
using Teknoroma.Entities.DAL.GenericRepository.Concrete;

namespace Teknoroma.Entities.BL.Managers.Concrete
{
    public class Manager<T> : Repository<T>, IManager<T> where T : class
    {
        public Manager(AppDbContext db) : base(db)
        {
        }

        public async Task<MyResult> InsertAsync(T entity, CancellationToken cancellationToken)
        {
            var result = new MyResult();
            try
            {
                await base.InsertAsync(entity, cancellationToken);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add(new MyError { Message = ex.Message });
            }
            return result;
        }

        public async Task<MyResult> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            var result = new MyResult();
            try
            {
                await base.UpdateAsync(entity, cancellationToken);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add(new MyError { Message = ex.Message });
            }
            return result;
        }

        public async Task<MyResult> DeleteAsync(T entity, CancellationToken cancellationToken)
        {
            var result = new MyResult();
            try
            {
                await base.DeleteAsync(entity, cancellationToken);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Errors.Add(new MyError { Message = ex.Message });
            }
            return result;
        }

        public async Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await base.GetByIdAsync(id, cancellationToken);
        }

        public async Task<T?> GetAsync(CancellationToken cancellationToken, Expression<Func<T, bool>> filter)
        {
            return await base.GetAsync(cancellationToken, filter);
        }

        public async Task<ICollection<T>?> GetAllAsync(CancellationToken cancellationToken, Expression<Func<T, bool>>? filter = null)
        {
            return await base.GetAllAsync(cancellationToken, filter);
        }

        public async Task<IQueryable<T>?> GetAllIncludeAsync(CancellationToken cancellationToken, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await base.GetAllIncludeAsync(cancellationToken, filter, include);
        }
    }
}
