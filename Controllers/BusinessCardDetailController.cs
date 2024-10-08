using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSBusinessInfoCard.Domain.Common;
using PSBusinessInfoCard.Domain.Models;
using PSBusinessInfoCard.Service.Interfaces;
using PSBusinessInfoCard.Service.UnitOfWork;

namespace PSBusinessInfoCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessCardDetailController : ControllerBase
    {
        private IServiceUnitOfWork _servicesUnitOfWorks;
        public BusinessCardDetailController(IServiceUnitOfWork servicesUnitOfWorks)
        {
            _servicesUnitOfWorks = servicesUnitOfWorks;
        }
        [HttpPost]
        public IResponseResult<BusinessCardDetail> Add(BusinessCardDetail entity)
        {

            using (_servicesUnitOfWorks)
                return _servicesUnitOfWorks.BusinessCardDetai.Value.Add(entity);

        }
        [HttpPut]
        public IResponseResult<BusinessCardDetail> Update(BusinessCardDetail entity)
        {

            using (_servicesUnitOfWorks)
                return _servicesUnitOfWorks.BusinessCardDetai.Value.Update(entity);

        }      
        [HttpGet]
        public IResponseResult<IEnumerable<BusinessCardDetail>> GetAll()
        {

            using (_servicesUnitOfWorks)
                return _servicesUnitOfWorks.BusinessCardDetai.Value.GetAll();

        }     
        [HttpGet("{id}")]
        public IResponseResult<BusinessCardDetail> Get(long id)
        {

            using (_servicesUnitOfWorks)
                return _servicesUnitOfWorks.BusinessCardDetai.Value.Get(id);

        }
        [HttpDelete]
        public IResponseResult<BusinessCardDetail> Remove(BusinessCardDetail entity)
        {

            using (_servicesUnitOfWorks)
                return _servicesUnitOfWorks.BusinessCardDetai.Value.Remove(entity);

        }
        //[HttpPost]
        //public IResponseResult<IEnumerable<BusinessCardDetail>> GetByCritera(EmployeesSearchCrietera searchCrietera)
        //{

        //    using (_servicesUnitOfWorks)
        //        return _servicesUnitOfWorks.EmployeeServices.Value.GetByCritera(searchCrietera);

        //}
    }
}
