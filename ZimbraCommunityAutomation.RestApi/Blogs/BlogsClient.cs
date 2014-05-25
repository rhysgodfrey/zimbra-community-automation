using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZimbraCommunityAutomation.RestApi.Blogs.Results;
using ZimbraCommunityAutomation.RestApi.Common;

namespace ZimbraCommunityAutomation.RestApi.Blogs
{
    public class BlogsClient : BaseClient, IBlogsClient
    {
        public BlogsClient(string baseUrl, string username, string apiKey)
            : base(baseUrl, username, apiKey)
        {
        }

        public BlogsApiResult GetAll(int? groupId = default(int), bool? includeSubGroups = default(bool), BlogSortBy sortBy = BlogSortBy.SortOrder, SortOrder sortOrder = SortOrder.Ascending, int? ownerUserId = default(int), int? pageSize = default(int), int? pageIndex = null)
        {
            var url = groupId.HasValue 
                ? string.Format("api.ashx/v2/groups/{0}/blogs.json", groupId.Value)
                : "api.ashx/v2/blogs.json";

            var parameters = new[]
            {
                new RequestParameter("SortOrder", sortOrder),
                new RequestParameter("SortBy", sortBy),
                new RequestParameter("IncludeSubGroups", includeSubGroups),
                new RequestParameter("OwnerUserId", ownerUserId),
                new RequestParameter("PageSize", pageSize),
                new RequestParameter("PageIndex", pageIndex)
            };

            return GetResult<BlogsApiResult>(url);
        }

        public BlogApiResult GetById(int id)
        {
            var url = string.Format("api.ashx/v2/blogs/{0}.json", id);

            return GetResult<BlogApiResult>(url);
        }

        public BlogApiResult GetByKey(string key, int groupId)
        {
            var url = string.Format("api.ashx/v2/groups/{0}/blogs/{1}.json", groupId, key);

            return GetResult<BlogApiResult>(url);
        }
    }
}
