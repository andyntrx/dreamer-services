using Dreamer.Aura.Api.Filters;
using Dreamer.Aura.Api.Wrappers;
using System.Collections.Generic;

namespace Dreamer.Aura.Api.Helpers
{
    public static class PaginationHelpers
    {
        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, int totalRecords, PaginationFilter pageFilter)
        {
            var response = new PagedResponse<List<T>>(pagedData, pageFilter.Limit, pageFilter.Page);
            var currentPage = ((double)totalRecords / (double)pageFilter.Limit);
            response.Limit = pagedData.Count;
            response.Data = pagedData;
            response.Page = (int)currentPage;

            return response;
        }
    }
}
