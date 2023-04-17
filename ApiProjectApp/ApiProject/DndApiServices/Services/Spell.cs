using System;
using ApiProject.DndApiServices.DataHandling.Models;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.HttpManager;
using Newtonsoft.Json.Linq;

namespace ApiProject.DndApiServices.Services
{
	public class SpellService : Services, IService
	{
        public DTO<SpellObject> SpellDTO { get; set; }
        public string SpellResponse;

        public SpellService()
        {
            CallManager = new CallManager();
            SpellDTO = new DTO<SpellObject>();
        }

        public async Task MakeRequestAsync(string section, string subsection)
        {
            SpellResponse = await CallManager.MakeARequestAsync(section, subsection);
            JsonResponse = JObject.Parse(SpellResponse);
            SpellDTO.DeserializeResponse(SpellResponse);
        }
    }
}

