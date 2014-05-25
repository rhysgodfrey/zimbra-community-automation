using ZimbraCommunityAutomation.RestApi.Common;
using ZimbraCommunityAutomation.RestApi.Groups.Results;

namespace ZimbraCommunityAutomation.RestApi.Groups
{
    public class GroupsClient : BaseClient, IGroupsClient
    {
        public GroupsClient(string baseUrl, string username, string apiKey)
            : base(baseUrl, username, apiKey)
        {
        }

        public GroupsApiResult GetAll()
        {
            return GetResult<GroupsApiResult>("api.ashx/v2/groups.json");
        }

        public GroupsApiResult GetByParentGroupId(int parentGroupId)
        {
            return GetResult<GroupsApiResult>(string.Format("api.ashx/v2/groups/{0}/groups.json", parentGroupId));
        }

        public GroupsApiResult GetForUser(string username)
        {
            return GetResult<GroupsApiResult>(string.Format("api.ashx/v2/users/{0}/groups.json", username));
        }

        public GroupsApiResult GetForUser(int userId)
        {
            return GetResult<GroupsApiResult>(string.Format("api.ashx/v2/users/{0}/groups.json", userId));
        }

        public GroupApiResult GetById(int groupId)
        {
            return GetResult<GroupApiResult>(string.Format("api.ashx/v2/groups/{0}.json", groupId));
        }

        public GroupApiResult GetRoot()
        {
            return GetResult<GroupApiResult>("api.ashx/v2/groups/root.json");
        }
    }
}
