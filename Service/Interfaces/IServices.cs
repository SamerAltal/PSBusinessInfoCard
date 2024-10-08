using PSBusinessInfoCard.Domain.Common;

namespace PSBusinessInfoCard.Service.Interfaces
{
    public interface IServices<Model>
    {
        IResponseResult<Model> Add(Model model);
        IResponseResult<Model> Get(long Id);
        IResponseResult<Model> Remove(Model model);
        IResponseResult<Model> Update(Model model);
        IResponseResult<IEnumerable<Model>> GetAll();
        IResponseResult<IEnumerable<Model>> AddRange(IEnumerable<Model> model);
        IResponseResult<IEnumerable<Model>> RemaoveRange(IEnumerable<Model> model);
        IResponseResult<IEnumerable<Model>> UpdateRange(IEnumerable<Model> model);

    }
}
