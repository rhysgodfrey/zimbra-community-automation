using System.Management.Automation;
using ZimbraCommunityAutomation.RestApi;

namespace ZimbraCommunityAutomation.Powershell.Common
{
    public abstract class BaseCmdlet : PSCmdlet
    {
        private IZimbraCommunityApiClient _apiClient;

        public abstract void ExecuteCmdlet();

        [Parameter(Position = 0, HelpMessage = "The base URL of the Zimbra Community Site", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string CommunityUrl { get; set; }

        [Parameter(Position = 2, HelpMessage = "The Zimbra Community API Key for the current user", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ApiKey { get; set; }

        [Parameter(Position = 1, HelpMessage = "The Zimbra Community username for the current user", Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ApiUsername { get; set; }

        protected IZimbraCommunityApiClient ApiClient
        {
            get
            {
                if (_apiClient == null)
                {
                    _apiClient = new ZimbraCommunityApiClient(CommunityUrl, ApiUsername, ApiKey);
                }

                return _apiClient;
            }
        }

        protected override void ProcessRecord()
        {
            ExecuteCmdlet();
        }
    }
}
