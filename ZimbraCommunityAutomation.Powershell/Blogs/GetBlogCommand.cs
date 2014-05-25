using System.Collections.Generic;
using System.Management.Automation;
using ZimbraCommunityAutomation.DataModel;
using ZimbraCommunityAutomation.Powershell.Common;

namespace ZimbraCommunityAutomation.Powershell.Blogs
{
    [Cmdlet(VerbsCommon.Get, "ZimbraCommunityBlog"), OutputType(typeof(Blog), typeof(IEnumerable<Blog>))]
    public class GetBlogCommand : BaseCmdlet
    {
        [Parameter(Position = 3, HelpMessage = "The Id of the blog to retrieve", ValueFromPipelineByPropertyName = true)]
        [Alias("BlogId")]
        public int Id { get; set; }

        [Parameter(Position = 3, HelpMessage = "The Key of the blog to retrieve (GroupId must be specified)", ValueFromPipelineByPropertyName = true)]
        public string Key { get; set; }

        [Parameter(Position = 3, HelpMessage = "The Group Id of the blog to retrieve", ValueFromPipelineByPropertyName = true)]
        public int GroupId { get; set; }

        public override void ExecuteCmdlet()
        {
            object result;

            if (Id > 0)
            {
                result = ApiClient.Blogs.GetById(Id).Blog;
            }
            else if (!string.IsNullOrWhiteSpace(Key) && GroupId > 0)
            {
                result = ApiClient.Blogs.GetByKey(Key, GroupId).Blog;
            }
            else if (GroupId > 0)
            {
                result = ApiClient.Blogs.GetAll(GroupId).Blogs;
            }
            else
            {
                result = ApiClient.Blogs.GetAll().Blogs;                
            }

            WriteObject(result);
        }
    }
}
