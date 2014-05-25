using System.Collections.Generic;
namespace ZimbraCommunityAutomation.DataModel
{
    public class Group
    {
        public string AvatarUrl { get; set; }
        public string DateCreated { get; set; }
        public string Description { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public int ParentGroupId { get; set; }
        public string Url { get; set; }
        public int TotalMembers { get; set; }
        public bool HasGroups { get; set; }
        public int GroupCount { get; set; }
        public int GroupType { get; set; }
        public bool EnableGroupMessages { get; set; }
        public bool EnableContact { get; set; }
        public string SearchUniqueId { get; set; }
        public bool IsEnabled { get; set; }
        public IEnumerable<ExtendedAttribute> ExtendedAttributes { get; set; }
        public string ContainerId { get; set; }
        public string ContainerTypeId { get; set; }
        public Container Container { get; set; }
        public int Id { get; set; }
    }
}