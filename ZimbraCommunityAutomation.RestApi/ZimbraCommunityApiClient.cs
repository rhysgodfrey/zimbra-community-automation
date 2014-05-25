using ZimbraCommunityAutomation.RestApi.BlogPosts;
using ZimbraCommunityAutomation.RestApi.Blogs;
using ZimbraCommunityAutomation.RestApi.Groups;

namespace ZimbraCommunityAutomation.RestApi
{
    public class ZimbraCommunityApiClient : IZimbraCommunityApiClient
    {
        public ZimbraCommunityApiClient(string baseUrl, string username, string apiKey)
        {
            Blogs = new BlogsClient(baseUrl, username, apiKey);
            Groups = new GroupsClient(baseUrl, username, apiKey);
            BlogPosts = new BlogPostsClient(baseUrl, username, apiKey);
        }

        public IBlogsClient Blogs
        {
            get; private set;
        }

        public IBlogPostsClient BlogPosts
        {
            get; private set;
        }

        public IGroupsClient Groups
        {
            get; private set;
        }
    }
}
