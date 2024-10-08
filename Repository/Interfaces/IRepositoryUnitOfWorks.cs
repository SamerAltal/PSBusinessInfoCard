namespace PSBusinessInfoCard.Repository.Interfaces
{
    public interface IRepositoryUnitOfWorks: IDisposable
    {
        Lazy<IBusinessCardDetailRepository> BusinessCardDetail { get; set; }

    }
}
