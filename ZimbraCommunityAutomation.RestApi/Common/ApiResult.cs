using System.Collections.Generic;

namespace ZimbraCommunityAutomation.RestApi
{
    public abstract class BaseApiResult
    {
        public IEnumerable<string> Info { get; set; }

        public IEnumerable<string> Warnings { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
