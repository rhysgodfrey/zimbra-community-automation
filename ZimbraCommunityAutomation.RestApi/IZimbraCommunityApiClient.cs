using ZimbraCommunityAutomation.RestApi.BlogPosts;
using ZimbraCommunityAutomation.RestApi.Blogs;
using ZimbraCommunityAutomation.RestApi.Groups;

namespace ZimbraCommunityAutomation.RestApi
{
    public interface IZimbraCommunityApiClient
    {
        IBlogsClient Blogs { get; }

        IGroupsClient Groups { get; }

        IBlogPostsClient BlogPosts { get; }
    }
}
