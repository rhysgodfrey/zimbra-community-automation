namespace ZimbraCommunityAutomation.DataModel
{
    public class Content
    {
        public UserDisplayDetails CreatedByUser { get; set; }
        public string ContentId { get; set; }
        public string ContentTypeId { get; set; }
        public string CreatedDate { get; set; }
        public string HtmlName { get; set; }
        public string HtmlDescription { get; set; }
        public string Url { get; set; }
        public string AvatarUrl { get; set; }
        public Application Application { get; set; }
    }
}