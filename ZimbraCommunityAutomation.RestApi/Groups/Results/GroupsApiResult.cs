using System.Collections.Generic;
using ZimbraCommunityAutomation.DataModel;

namespace ZimbraCommunityAutomation.RestApi.Groups.Results
{
    public class GroupsApiResult : BaseApiResult
    {
        public IEnumerable<Group> Groups { get; set; }
    }
}
