using System;
using ApiProject.DndApiServices.HttpManager;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.DataHandling.Models;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace ApiProject.DndApiServices.Services
{
    public class Services
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string ResponseAsString { get; set; }

        public Services()
        {

        }

        public IService MakeAServices(string serviceType)
        {
            if (serviceType == "monsters")
            {
                MonsterService monsterService = new MonsterService();
                return monsterService;
            }
            if (serviceType == "classes")
            {
                DndClassService dndClassService = new DndClassService();
                return dndClassService;
            }
            if (serviceType == "spells")
            {
                SpellService spellService = new SpellService();
                return spellService;
            }
            else
            {
                NullService nullService = new NullService();
                return nullService;
            }
        }

        public int GetStatusCode() => (int)CallManager.CallManagerResponse.StatusCode;
        public string GetResponseContentType() => CallManager.CallManagerResponse.Content.Headers.ContentType.MediaType;
        public List<string> GetHeaders()
        {
            List<string> headers = new List<string>();
            foreach (var header in CallManager.CallManagerResponse.Headers)
            {
                headers.Add(header.Key);
            }
            return headers;
        }
        public async Task<string> GetErrorMessageAsync() => await CallManager.CallManagerResponse.Content.ReadAsStringAsync();
    }
}

