using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

namespace ApiProject.DndApiServices.HttpManager
{
	public class CallManager
	{
        private readonly HttpClient _client;

        public HttpResponseMessage CallManagerResponse { get; set; }

        public CallManager()
        {
            _client = new HttpClient();
        }

        // section can be something like 'class', 'monster' or 'spell'
        // subsection is the specific monster, say, such as 'adult-black-dragon'
        public async Task<string> MakeARequestAsync(string section, string subsection)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, @$"{AppConfigReader.BaseUrl}{section}/{subsection}");
            CallManagerResponse = await _client.SendAsync(request);
            //CallManagerResponse.EnsureSuccessStatusCode();
            return await CallManagerResponse.Content.ReadAsStringAsync();
        }
    }
}

