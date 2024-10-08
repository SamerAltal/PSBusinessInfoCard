using PSBusinessInfoCard.Domain.Models;
using System.Linq.Expressions;using System.Collections.Generic;
using PSBusinessInfoCard.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PSBusinessInfoCard.Repository.Common
{
    public class Repository<IEntity> : IRepository<IEntity> where IEntity : BaseClass, new()
    {
        private BusinessCardInfoContext _context;

        public Repository(BusinessCardInfoContext context) //: base(context)
        {
            _context = context;
        }
        public IEntity Add(IEntity entity)
        {
            _context.Set<IEntity>().Add(entity);
            _context.SaveChanges();
            _context.Entry(entity).GetDatabaseValues();
            return entity;
        }

        public IEnumerable<IEntity> AddRange(IEnumerable<IEntity> entity)
        {
            // _context.ChangeTracker.Entries<IEntity>();
            _context.Set<IEntity>().AddRange(entity);
            _context.SaveChanges();
            // _context.Entry(entity).GetDatabaseValues();
            return entity;
        }

        public IQueryable<IEntity> Find(Expression<Func<IEntity, bool>> where, params Expression<Func<IEntity, object>>[] Navigation)
        {

            IQueryable<IEntity> dbQuery = _context.Set<IEntity>();
            foreach (Expression<Func<IEntity, object>> x in Navigation)
            {
                dbQuery = dbQuery.Include(x).AsNoTracking();

            }
            return dbQuery.Where(where).AsNoTracking();

        }

     

        //public IQueryable<IEntity> Find(Expression<Func<IEntity, bool>> where, params Expression<Func<IEntity, object>>[] Navigation)
        //{
        //    throw new NotImplementedException();
        //}

        public IEntity Get(long Id)
        {
            IEntity entity = _context.Set<IEntity>().AsNoTracking().Where(x => x.Id == Id).FirstOrDefault();
            return entity;
        }

        public IEntity Remove(IEntity entity)
        {
            _context.Set<IEntity>().Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<IEntity> RemoveRange(IEnumerable<IEntity> entity)
        {
            _context.Set<IEntity>().RemoveRange(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEntity update(IEntity entity)
        {
            _context.Set<IEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<IEntity> update(IEnumerable<IEntity> entity)
        {
            _context.Set<IEntity>().UpdateRange(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
