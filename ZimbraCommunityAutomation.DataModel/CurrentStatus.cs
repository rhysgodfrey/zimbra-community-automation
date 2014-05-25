namespace ZimbraCommunityAutomation.DataModel
{
    public class CurrentStatus
    {
        public UserDisplayDetails Author { get; set; }
        public string Body { get; set; }
        public string CreatedDate { get; set; }
        public int ReplyCount { get; set; }
        public Group Group { get; set; }
        public string AttachedUrl { get; set; }
        public bool HasReplies { get; set; }
        public string ContentId { get; set; }
        public string ContentType { get; set; }
        public string Url { get; set; }
        public Content Content { get; set; }
        public string Id { get; set; }
    }
}