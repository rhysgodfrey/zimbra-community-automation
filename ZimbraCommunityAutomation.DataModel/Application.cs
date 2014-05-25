namespace ZimbraCommunityAutomation.DataModel
{
    public class Application
    {
        public string ApplicationId { get; set; }
        public string ApplicationTypeId { get; set; }
        public string HtmlName { get; set; }
        public string HtmlDescription { get; set; }
        public string Url { get; set; }
        public string AvatarUrl { get; set; }
        public Container Container { get; set; }
    }
}