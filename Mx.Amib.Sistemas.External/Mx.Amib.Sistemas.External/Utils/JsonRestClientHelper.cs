using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Mx.Amib.Sistemas.External.Utils
{
    public class JsonRestClientHelper
    {
        public static T Get<T>(string baseUrl, string requestUrl)
        {
            T result = default(T);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(requestUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsAsync<T>().Result;
                }
            }
            return result;
        }

        public static T Post<T>(string baseUrl, string requestUrl, T requestObj)
        {
            T result = default(T);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync<T>(requestUrl,requestObj).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsAsync<T>().Result;
                }
            }
            return result;
        }
    }
}
