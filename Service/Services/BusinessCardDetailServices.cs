using PSBusinessInfoCard.Domain.Common;
using PSBusinessInfoCard.Domain.Models;
using PSBusinessInfoCard.Repository.Interfaces;
using PSBusinessInfoCard.Service.Interfaces;

namespace PSBusinessInfoCard.Service.Services
{
    public class BusinessCardDetailServices: IBusinessCardDetailServices
    {
        private IRepositoryUnitOfWorks _repositoryUnitOfWorks;
        public BusinessCardDetailServices(IRepositoryUnitOfWorks repositoryUnitOfWorks)
        {
            _repositoryUnitOfWorks = repositoryUnitOfWorks;
        }

        public IResponseResult<BusinessCardDetail> Add(BusinessCardDetail model)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<IEnumerable<BusinessCardDetail>> AddRange(IEnumerable<BusinessCardDetail> model)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<BusinessCardDetail> Get(long Id)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<IEnumerable<BusinessCardDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponseResult<IEnumerable<BusinessCardDetail>> RemaoveRange(IEnumerable<BusinessCardDetail> model)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<BusinessCardDetail> Remove(BusinessCardDetail model)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<BusinessCardDetail> Update(BusinessCardDetail model)
        {
            throw new NotImplementedException();
        }

        public IResponseResult<IEnumerable<BusinessCardDetail>> UpdateRange(IEnumerable<BusinessCardDetail> model)
        {
            throw new NotImplementedException();
        }
    }
}
