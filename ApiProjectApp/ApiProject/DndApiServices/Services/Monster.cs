using System;
using ApiProject.DndApiServices.DataHandling.Models;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.HttpManager;
using Newtonsoft.Json.Linq;

namespace ApiProject.DndApiServices.Services
{
	public class MonsterService : Services
	{
        public DTO<MonsterObject> MonsterDTO { get; set; }
        public string MonsterResponse;

        public MonsterService()
        {
            CallManager = new CallManager();
            MonsterDTO = new DTO<MonsterObject>();
        }

        public async Task MakeRequestAsync(string section, string subsection)
        {
            MonsterResponse = await CallManager.MakeARequestAsync(section, subsection);
            JsonResponse = JObject.Parse(MonsterResponse);
            MonsterDTO.DeserializeResponse(MonsterResponse);
        }
    }
}

