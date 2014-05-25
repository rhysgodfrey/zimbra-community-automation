using ZimbraCommunityAutomation.RestApi.Blogs.Results;

namespace ZimbraCommunityAutomation.RestApi.Blogs
{
    public interface IBlogsClient
    {
        BlogsApiResult GetAll(int? groupId = null, bool? includeSubGroups = null, BlogSortBy sortBy = BlogSortBy.SortOrder, SortOrder sortOrder = SortOrder.Ascending, int? ownerUserId = null, int? pageSize = null, int? pageIndex = null);

        BlogApiResult GetById(int id);

        BlogApiResult GetByKey(string key, int groupId);
    }
}
