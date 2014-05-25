using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimbraCommunityAutomation.RestApi.BlogPosts.Requests;
using ZimbraCommunityAutomation.RestApi.BlogPosts.Results;

namespace ZimbraCommunityAutomation.RestApi.BlogPosts
{
    public interface IBlogPostsClient
    {
        BlogPostApiResult GetById(int blogId, int blogPostId);

        BlogPostApiResult GetByName(int blogId, string blogPostName);

        BlogPostApiResult Create(int blogId, CreateBlogPostRequest request);
    }
}
