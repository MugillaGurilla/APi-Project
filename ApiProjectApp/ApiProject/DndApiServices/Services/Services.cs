using System;
using ApiProject.DndApiServices.HttpManager;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.DataHandling.Models;
using Newtonsoft.Json.Linq;

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
        public async Task<string> GetErrorMessageAsync() => await CallManager.CallManagerResponse.Content.ReadAsStringAsync();
    }
}

