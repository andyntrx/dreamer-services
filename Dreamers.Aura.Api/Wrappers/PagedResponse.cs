namespace Dreamers.Aura.Api.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int Limit { get; set; }
        public int Page { get; set; }

        public PagedResponse(T data, int limit, int page)
        {
            this.Limit = limit;
            this.Page = page;
            this.Data = data;
            this.Message = null;
            this.Succeeded = true;
            this.Errors = null;
        }
    }
}
