namespace PSBusinessInfoCard.Domain.Common
{
    public interface IResponseResult<T>
    {
        List<string> Errors { get; set; }
        ResultState status { get; set; }
        T Data { get; set; }
        long ToatalRecocrd { get; set; }
    }
}
