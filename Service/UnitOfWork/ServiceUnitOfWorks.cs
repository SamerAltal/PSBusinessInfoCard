using PSBusinessInfoCard.Domain.Models;
using PSBusinessInfoCard.Repository.Interfaces;
using PSBusinessInfoCard.Repository.UnitOfWork;
using PSBusinessInfoCard.Service.Interfaces;
using PSBusinessInfoCard.Service.Services;

namespace PSBusinessInfoCard.Service.UnitOfWork
{
    public class ServiceUnitOfWorks: IServiceUnitOfWorks
    {
        private IRepositoryUnitOfWorks _repositoryUnitOfWorks;
        public Lazy<IBusinessCardDetailServices> BusinessCardDetai { get; set; }

        public ServiceUnitOfWorks(BusinessCardInfoContext context)
        {
            _repositoryUnitOfWorks = new RepositoryUnitOfWorks(context);

            BusinessCardDetai = new Lazy<IBusinessCardDetailServices>(() => new BusinessCardDetailServices(_repositoryUnitOfWorks));
        }
        public void Dispose()
        {
            BusinessCardDetai = null;
        }
    }
}
