namespace PSBusinessInfoCard.Service.Interfaces
{
    public interface IServiceUnitOfWork:IDisposable
    {
        Lazy<IBusinessCardDetailServices> BusinessCardDetai { get; set; }

    }
}
