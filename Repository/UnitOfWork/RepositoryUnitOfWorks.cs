using PSBusinessInfoCard.Domain.Models;
using PSBusinessInfoCard.Repository.Interfaces;
using PSBusinessInfoCard.Repository.repositories;

namespace PSBusinessInfoCard.Repository.UnitOfWork
{
    public class RepositoryUnitOfWorks : IRepositoryUnitOfWorks
    {
        private BusinessCardInfoContext _context;
        public Lazy<IBusinessCardDetailRepository> BusinessCardDetail{ get; set; }

        public RepositoryUnitOfWorks(BusinessCardInfoContext context)
        {
            _context = context;

            BusinessCardDetail = new Lazy<IBusinessCardDetailRepository>(() => new BusinessCardDetailRepository(_context));
        }

        public void Dispose()
        {
            BusinessCardDetail = null;
        }
    }
}
