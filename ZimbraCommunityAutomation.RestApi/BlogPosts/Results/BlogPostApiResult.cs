using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimbraCommunityAutomation.DataModel;

namespace ZimbraCommunityAutomation.RestApi.BlogPosts.Results
{
    public class BlogPostApiResult : BaseApiResult
    {
        public BlogPost BlogPost { get; set; }
    }
}
