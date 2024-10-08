using PSBusinessInfoCard.Domain.Models;
using PSBusinessInfoCard.Repository.Common;
using PSBusinessInfoCard.Repository.Interfaces;

namespace PSBusinessInfoCard.Repository.repositories
{
    public class BusinessCardDetailRepository : Repository<BusinessCardDetail> , IBusinessCardDetailRepository
    {
        private BusinessCardInfoContext _context;
        public BusinessCardDetailRepository(BusinessCardInfoContext context) : base(context)
        {
            _context = context;
        }
    }
}
