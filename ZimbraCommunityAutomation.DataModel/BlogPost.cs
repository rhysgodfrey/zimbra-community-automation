using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimbraCommunityAutomation.DataModel
{
    public class BlogPost
    {
        public int Id { get; set; }

        public Guid ContentId { get; set; }

        public Guid ContentTypeId { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        public string Url { get; set; }

        public string TitleUrl { get; set; }

        public DateTime PublisedDate { get; set; }

        public string Excerpt { get; set; }

        public int ExcerptSize { get; set; }

        public bool UsePostSummary { get; set; }

        public bool GeneratePostSummary { get; set; }

        public string Body { get; set; }

        public int BlogId { get; set; }

        public int GroupId { get; set; }

        public bool IsApproved { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsCrossPostingEnabled { get; set; }

        public string FeaturedImage { get; set; }

        public string IsPostEnabled { get; set; }

        public bool IsExternal { get; set; }

        public bool IsLocked { get; set; }

        public int CommentCount { get; set; }

        public int Views { get; set; }

        public Tag[] Tags { get; set; }

        public UserDisplayDetails Author { get; set; }

        public IEnumerable<ExtendedAttribute> ExtendedAttributes { get; set; }

        public Content Content { get; set; }
    }
}
