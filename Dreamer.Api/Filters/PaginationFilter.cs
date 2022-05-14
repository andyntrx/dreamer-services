namespace Dreamer.Aura.Api.Filters
{
    public class PaginationFilter
    {
        public int Limit { get; set; }
        public int Page { get; set; }

        public PaginationFilter()
        {

            this.Page = 1;
            this.Limit = 10;
        }
        public PaginationFilter(int page, int limit)
        {
            this.Page = page < 1 ? 1 : page;
            this.Limit = limit > 10 ? 10 : limit;
        }
    }
}
