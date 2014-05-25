namespace ZimbraCommunityAutomation.RestApi.Common
{
    public class RequestParameter
    {
        internal RequestParameter(string key, object value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; private set; }

        public object Value { get; private set; }
    }
}
