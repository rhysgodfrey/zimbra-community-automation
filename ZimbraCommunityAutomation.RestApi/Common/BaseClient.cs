using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace ZimbraCommunityAutomation.RestApi.Common
{
    public abstract class BaseClient
    {
        private readonly string _baseUrl;
        private readonly string _username;
        private readonly string _apiKey;

        public BaseClient(string baseUrl, string username, string apiKey)
        {
            _baseUrl = baseUrl;
            _username = username;
            _apiKey = apiKey;
        }

        protected T GetResult<T>(string url) 
        {
            return GetResult<T>(url, Enumerable.Empty<RequestParameter>());
        }

        protected T GetResult<T>(string url, IEnumerable<RequestParameter> parameters)
        {
            var client = new WebClient();

            client.BaseAddress = _baseUrl;
                        
            client.Headers.Add("Rest-User-Token", GetUserToken());

            try
            {
                var result = client.DownloadString(FormatUrlWithParameters(url, parameters));

                return JsonConvert.DeserializeObject<T>(result);
            }
            catch(WebException ex)
            {
                using(var responseStream = ex.Response.GetResponseStream())
                {
                    using(var responseReader = new StreamReader(responseStream))
                    {
                        var response = responseReader.ReadToEnd();

                        return JsonConvert.DeserializeObject<T>(response);
                    }
                }
            }
        }

        protected TResponse PostRequest<TResponse, TRequest>(string url, TRequest request)
        {
            var client = new WebClient();

            client.BaseAddress = _baseUrl;

            client.Headers.Add("Rest-User-Token", GetUserToken());
            
            try
            {
                var result = client.UploadValues(url, "POST", GetPostValues(request));

                var resultString = Encoding.UTF8.GetString(result);

                return JsonConvert.DeserializeObject<TResponse>(resultString);
            }
            catch (WebException ex)
            {
                using (var responseStream = ex.Response.GetResponseStream())
                {
                    using (var responseReader = new StreamReader(responseStream))
                    {
                        var response = responseReader.ReadToEnd();

                        return JsonConvert.DeserializeObject<TResponse>(response);
                    }
                }
            }
        }

        private NameValueCollection GetPostValues<TRequest>(TRequest request)
        {
            var type = typeof(TRequest);

            var values = new NameValueCollection();

            var properties = type.GetProperties();

            foreach(var property in properties)
            {
                var value = property.GetValue(request);

                if (Nullable.GetUnderlyingType(property.PropertyType) != null && value == null)
                {
                    continue;
                }

                if (property.PropertyType == typeof(string) && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
                {
                    continue;
                }

                if (property.PropertyType == typeof(DateTime?))
                {
                    var date = (DateTime?)value;

                    value = date.Value.ToString("O");
                }

                values[property.Name] = value.ToString();
            }

            return values;
        }

        private string FormatUrlWithParameters(string url, IEnumerable<RequestParameter> parameters)
        {
            var setParameters = parameters.Where(p => p.Value != null && !string.IsNullOrWhiteSpace(p.Value.ToString()))
                .Select(p => string.Format("{0}={1}", p.Key, p.Value));

            if (setParameters.Any())
            {
                return string.Format("{0}?{1}", url, string.Join("&", setParameters.ToArray()));
            }

            return url;
        }

        private string GetUserToken()
        {
            var adminKey = String.Format("{0}:{1}", _apiKey, _username);
            var adminKeyBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(adminKey));

            return adminKeyBase64;
        }
    }
}
