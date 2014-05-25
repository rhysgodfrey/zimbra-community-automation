using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimbraCommunityAutomation.RestApi.BlogPosts.Requests;
using ZimbraCommunityAutomation.RestApi.BlogPosts.Results;
using ZimbraCommunityAutomation.RestApi.Common;

namespace ZimbraCommunityAutomation.RestApi.BlogPosts
{
    public class BlogPostsClient : BaseClient, IBlogPostsClient
    {
        public BlogPostsClient(string baseUrl, string username, string apiKey)
            : base(baseUrl, username, apiKey)
        {
        }

        public BlogPostApiResult GetById(int blogId, int blogPostId)
        {
            var url = string.Format("api.ashx/v2/blogs/{0}/posts/{1}.json", blogId, blogPostId);

            return GetResult<BlogPostApiResult>(url);
        }

        public BlogPostApiResult GetByName(int blogId, string blogPostName)
        {
            var url = string.Format("api.ashx/v2/blogs/{0}/posts/{1}.json", blogId, blogPostName);

            return GetResult<BlogPostApiResult>(url);
        }

        public BlogPostApiResult Create(int blogId, CreateBlogPostRequest request)
        {
            var url = string.Format("api.ashx/v2/blogs/{0}/posts.json", blogId);

            return PostRequest<BlogPostApiResult, CreateBlogPostRequest>(url, request);
        }
    }
}
