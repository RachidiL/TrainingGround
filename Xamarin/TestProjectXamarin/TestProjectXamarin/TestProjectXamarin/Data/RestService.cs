using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Model;

namespace TestProjectXamarin.Data
{
    public class RestService
    {
        HttpClient client;
        string _grantType = "password";
        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded' "));
        }

        public async Task<Token> Login(User user)
        {
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", _grantType));
            postData.Add(new KeyValuePair<string, string>("username", user.Username));
            postData.Add(new KeyValuePair<string, string>("password", user.Password));
            var content = new FormUrlEncodedContent(postData);
            var weburl = "www.test.com";
            var response = await PostResponseLogin<Token>(weburl, content);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            response.ExpireDate = dt.AddSeconds(response.ExpireIn);
            return response;
        }

        public async Task<T> PostResponseLogin<T>(string weburl, FormUrlEncodedContent content) where T : class
        {
            var response = await client.PostAsync(weburl, content);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<T>(jsonResult);
            return responseObject;
        }

        public async Task<T> PostResponse<T>(string weburl, string jsonString) where T : class
        {
            var token = App.TokenDatabase.GetToken();
            string contentType = "application/json";
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
            try
            {
                var result = await client.PostAsync(weburl, new StringContent(jsonString, Encoding.UTF8, contentType));
                if(result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonResult = result.Content.ReadAsStringAsync().Result;
                    try
                    {
                        var contentResp = JsonConvert.DeserializeObject<T>(jsonResult);
                        return contentResp;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public async Task<T> GetResponse<T>(string weburl) where T : class
        {
            var token = App.TokenDatabase.GetToken();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
            var response = await client.GetAsync(weburl);
            var jsonResult = response.Content.ReadAsStringAsync().Result;
            var contentResp = JsonConvert.DeserializeObject<T>(jsonResult);
            return contentResp;
        }
    }
}
