using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SharpIdentityProg.Data;
using System.Linq.Expressions;
using Threenine.Data;
using Threenine.Data.Paging;

namespace SharpRepositoryServiceProg
{
    internal class IdentityRepo : IRepository<ApplicationUser>
    {
        private ApplicationDbContext db;

        public int Commit()
        {
            var result = db.SaveChanges();
            return result;
        }

        public IdentityRepo(
            string connectionString)
        {
            db = new ApplicationDbContext(connectionString);

            var pendingMigrations = db.Database.GetPendingMigrations().ToList();
            if (pendingMigrations.Any())
            {
                db.Database.Migrate();
            }
        }

        public ApplicationUser Insert(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(params ApplicationUser[] entities)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ApplicationUser> entities)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser InsertNotExists(Expression<Func<ApplicationUser, bool>> predicate, ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicationUser[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ApplicationUser> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params ApplicationUser[] entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ApplicationUser> entities)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser SingleOrDefault(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser SingleOrDefault(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser SingleOrDefault(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser SingleOrDefault(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include, bool enableTracking)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser SingleOrDefault(Expression<Func<ApplicationUser, bool>> predicate = null, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy = null, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include = null, bool enableTracking = true, bool ignoreQueryFilters = false)
        {
            throw new NotImplementedException();
        }

        public TResult SingleOrDefault<TResult>(Expression<Func<ApplicationUser, TResult>> selector, Expression<Func<ApplicationUser, bool>> predicate = null, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy = null, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include = null, bool disableTracking = true, bool ignoreQueryFilters = false)
        {
            throw new NotImplementedException();
        }

        public IPaginate<ApplicationUser> GetList(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IPaginate<ApplicationUser> GetList(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy)
        {
            throw new NotImplementedException();
        }

        public IPaginate<ApplicationUser> GetList(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include)
        {
            throw new NotImplementedException();
        }

        public IPaginate<ApplicationUser> GetList(Expression<Func<ApplicationUser, bool>> predicate, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include, int index, int size)
        {
            throw new NotImplementedException();
        }

        public IPaginate<ApplicationUser> GetList(Expression<Func<ApplicationUser, bool>> predicate = null, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy = null, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include = null, int index = 0, int size = 20, bool enableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IPaginate<TResult> GetList<TResult>(Expression<Func<ApplicationUser, TResult>> selector, Expression<Func<ApplicationUser, bool>> predicate = null, Func<IQueryable<ApplicationUser>, IOrderedQueryable<ApplicationUser>> orderBy = null, Func<IQueryable<ApplicationUser>, IIncludableQueryable<ApplicationUser, object>> include = null, int index = 0, int size = 20, bool enableTracking = true) where TResult : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
