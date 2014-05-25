using System.Collections.Generic;
using ZimbraCommunityAutomation.DataModel;

namespace ZimbraCommunityAutomation.RestApi.Blogs.Results
{
    public class BlogsApiResult : BaseApiResult
    {
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
