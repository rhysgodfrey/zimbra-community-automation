using System.Collections.Generic;

namespace ZimbraCommunityAutomation.DataModel
{
    public class Blog
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Group Group { get; set; }
        public IEnumerable<UserDisplayDetails> Authors { get; set; }
        public string DateCreated { get; set; }
        public string LatestPostDate { get; set; }
        public bool Enabled { get; set; }
        public bool EnableAbout { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public bool EnableCommentsOverride { get; set; }
        public bool ShowContact { get; set; }
        public int PostSummaryLengthDefault { get; set; }
        public int PostCount { get; set; }
        public int CommentCount { get; set; }
        public string SearchUniqueId { get; set; }
        public Application Application { get; set; }
        public string Title { get; set; }
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        public int Id { get; set; }
    }
}