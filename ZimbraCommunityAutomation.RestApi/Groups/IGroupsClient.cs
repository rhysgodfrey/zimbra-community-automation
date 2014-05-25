using ZimbraCommunityAutomation.RestApi.Groups.Results;

namespace ZimbraCommunityAutomation.RestApi.Groups
{
    public interface IGroupsClient
    {
        GroupsApiResult GetAll();

        GroupsApiResult GetByParentGroupId(int parentGroupId);

        GroupsApiResult GetForUser(int userId);

        GroupsApiResult GetForUser(string username);

        GroupApiResult GetById(int groupId);

        GroupApiResult GetRoot();
    }
}
