using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DockerComms_Web
{
    public class Proxy
    {
        private HttpClient _client = new HttpClient();
        public Proxy()
        {

        }

        public async Task<string> MakeApiCallAsync()
        {
            var apiUrl = Startup.Configuration.GetValue<string>("ApiUrl");
            try
            {
                return await _client.GetStringAsync(apiUrl);
            } catch (Exception ex)
            {
                return $"Exception: [{ex.Message}]";
            }
        }
    }
}
