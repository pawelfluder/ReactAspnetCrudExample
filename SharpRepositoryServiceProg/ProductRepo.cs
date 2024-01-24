using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SharpCountriesProg.Models;
using System.Linq.Expressions;
using Threenine.Data;
using Threenine.Data.Paging;

namespace SharpRepositoryServiceProg
{
    internal class CountryRepo : IRepository<Country>
    {
        private readonly IUnitOfWork unitOfWork;
        private CountriesDbContext db;

        public int Commit()
        {
            var result = db.SaveChanges();
            return result;
        }

        public CountryRepo(
            IUnitOfWork unitOfWork,
            string connectionString)
        {
            this.unitOfWork = unitOfWork;
            db = new CountriesDbContext(connectionString);

            var pendingMigrations = db.Database.GetPendingMigrations().ToList();
            if (pendingMigrations.Any())
            {
                db.Database.Migrate();
            }
        }

        public Country Insert(Country entity)
        {
            throw new NotImplementedException();
            //_unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Insert(params Country[] entities)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Country> entities)
        {
            db.Countries.AddRange(entities);
        }

        public Country InsertNotExists(Expression<Func<Country, bool>> predicate, Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(params Country[] entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Country> entities)
        {
            db.Set<Country>().RemoveRange(entities);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Country> GetCountrysList()
        {
            var result = db.Countries.ToList();
            return result;
        }

        public IPaginate<Country> GetList(Expression<Func<Country, bool>> predicate)
        {
            var result = db.Set<Country>().Where(predicate);
            var paginate = new Paginate<Country>(result);
            return paginate;
        }

        public IPaginate<Country> GetList(
            Expression<Func<Country, bool>> predicate,
            Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy)
        {
            throw new NotImplementedException();
        }

        public IPaginate<Country> GetList(
            Expression<Func<Country, bool>> predicate,
            Func<IQueryable<Country>,
            IOrderedQueryable<Country>> orderBy,
            Func<IQueryable<Country>,
            IIncludableQueryable<Country, object>> include)
        {
            throw new NotImplementedException();
        }

        public IPaginate<Country> GetList(Expression<Func<Country, bool>> predicate, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy, Func<IQueryable<Country>, IIncludableQueryable<Country, object>> include, int index, int size)
        {
            throw new NotImplementedException();
        }

        public IPaginate<Country> GetList(
            Expression<Func<Country, bool>> predicate = null,
            Func<IQueryable<Country>,
            IOrderedQueryable<Country>> orderBy = null,
            Func<IQueryable<Country>,
            IIncludableQueryable<Country, object>> include = null,
            int index = 0,
            int size = 20,
            bool enableTracking = true)
        {
            var result2 = db.Set<Country>().ToList();
            var result = db.Set<Country>();
            var paginate = new Paginate<Country>(result);
            return paginate;
        }

        public IPaginate<TResult> GetList<TResult>(
            Expression<Func<Country, TResult>> selector,
            Expression<Func<Country, bool>> predicate = null,
            Func<IQueryable<Country>,
            IOrderedQueryable<Country>> orderBy = null,
            Func<IQueryable<Country>,
            IIncludableQueryable<Country, object>> include = null,
            int index = 0,
            int size = 20,
            bool enableTracking = true)
                where TResult : class
        {
            var result2 = db.Set<Country>().ToList();
            var result = db.Set<TResult>();
            var paginate = new Paginate<TResult>(result);
            return paginate;
        }

        public Country SingleOrDefault(Expression<Func<Country, bool>> predicate)
        {
            var result = db.Set<Country>().SingleOrDefault(predicate);
            return result;
        }

        public Country SingleOrDefault(Expression<Func<Country, bool>> predicate, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy)
        {
            throw new NotImplementedException();
        }

        public Country SingleOrDefault(Expression<Func<Country, bool>> predicate, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy, Func<IQueryable<Country>, IIncludableQueryable<Country, object>> include)
        {
            throw new NotImplementedException();
        }

        public Country SingleOrDefault(Expression<Func<Country, bool>> predicate, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy, Func<IQueryable<Country>, IIncludableQueryable<Country, object>> include, bool enableTracking)
        {
            throw new NotImplementedException();
        }

        public Country SingleOrDefault(Expression<Func<Country, bool>> predicate = null, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy = null, Func<IQueryable<Country>, IIncludableQueryable<Country, object>> include = null, bool enableTracking = true, bool ignoreQueryFilters = false)
        {
            throw new NotImplementedException();
        }

        public TResult SingleOrDefault<TResult>(Expression<Func<Country, TResult>> selector, Expression<Func<Country, bool>> predicate = null, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy = null, Func<IQueryable<Country>, IIncludableQueryable<Country, object>> include = null, bool disableTracking = true, bool ignoreQueryFilters = false)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Update(params Country[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Country> entities)
        {
            db.Countries.UpdateRange(entities);
        }
    }
}
