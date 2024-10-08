using PSBusinessInfoCard.Domain.Enum;

namespace PSBusinessInfoCard.Domain.Common
{
    public class ResponseResult<T> : IResponseResult<T>
    {
        public List<string> Errors { get; set; }
        public ResultState status { get; set; }
        public T Data { get; set; }
        public long ToatalRecocrd { get; set; }
    }
}
