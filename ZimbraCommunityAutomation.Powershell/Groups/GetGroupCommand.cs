using System.Collections.Generic;
using System.Management.Automation;
using ZimbraCommunityAutomation.DataModel;
using ZimbraCommunityAutomation.Powershell.Common;

namespace ZimbraCommunityAutomation.Powershell.Groups
{
    [Cmdlet(VerbsCommon.Get, "ZimbraCommunityGroup"), OutputType(typeof(Group), typeof(IEnumerable<Group>))]
    public class GetGroupCommand : BaseCmdlet
    {
        [Parameter(Position = 3, HelpMessage = "The Id of the parent group to retrieve groups for", ValueFromPipelineByPropertyName = true)]
        public int ParentGroupId { get; set; }

        [Parameter(Position = 3, HelpMessage = "The Id of the user to retrieve groups for", ValueFromPipelineByPropertyName = true)]
        public int UserId { get; set; }

        [Parameter(Position = 3, HelpMessage = "The username of the user to retrieve groups for", ValueFromPipelineByPropertyName = true)]
        public string Username { get; set; }

        [Parameter(Position = 3, HelpMessage = "The Id of the group to retrieve", ValueFromPipelineByPropertyName = true)]
        [Alias("GroupId")]
        public int Id { get; set; }

        [Parameter(Position = 3, HelpMessage = "If the root group should be returned", ValueFromPipelineByPropertyName = true)]
        public bool Root { get; set; }

        public override void ExecuteCmdlet()
        {
            object result;

            if (ParentGroupId > 0)
            {
                result = ApiClient.Groups.GetByParentGroupId(ParentGroupId).Groups;
            }
            else if (UserId > 0)
            {
                result = ApiClient.Groups.GetForUser(UserId).Groups;
            }
            else if (!string.IsNullOrWhiteSpace(Username))
            {
                result = ApiClient.Groups.GetForUser(Username).Groups;
            }
            else if (Root)
            {
                result = ApiClient.Groups.GetRoot().Group;
            }
            else if (Id > 0)
            {
                result = ApiClient.Groups.GetById(Id).Group;
            }
            else
            {
                result = ApiClient.Groups.GetAll().Groups;
            }

            WriteObject(result);
        }
    }
}
