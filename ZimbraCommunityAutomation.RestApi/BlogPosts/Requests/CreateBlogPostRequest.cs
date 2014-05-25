using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimbraCommunityAutomation.RestApi.BlogPosts.Requests
{
    public class CreateBlogPostRequest
    {
        //public int BlogId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Slug { get; set; }

        public string Excerpt { get; set; }

        public int? ExcerptSize { get; set; }

        public bool? UsePostSummary { get; set; }

        public bool? GeneratePostSummary { get; set; }

        public DateTime? PublishedDate { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsFeatured { get; set; }

        public bool? IsCrossPostingEnabled { get; set; }

        public string FeaturedImage { get; set; }

        public string Tags { get; set; }
    }
}
