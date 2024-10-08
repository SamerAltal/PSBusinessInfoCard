using System.Linq.Expressions;

namespace PSBusinessInfoCard.Repository.Interfaces
{
    public interface IRepository<IEntity> where IEntity : class
    {
        IEntity Get(long Id);
        IEntity Add(IEntity entity);
        IEnumerable<IEntity> AddRange(IEnumerable<IEntity> entity);
        IEntity update(IEntity entity);
        IEnumerable<IEntity> update(IEnumerable<IEntity> entity);
        IEntity Remove(IEntity entity);
        IEnumerable<IEntity> RemoveRange(IEnumerable<IEntity> entity);
        IQueryable<IEntity> Find(Expression<Func<IEntity, bool>> where, params Expression<Func<IEntity, object>>[] Navigation);

    }
}
