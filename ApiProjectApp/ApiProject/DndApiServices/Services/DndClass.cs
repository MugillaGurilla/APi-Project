using System;
using ApiProject.DndApiServices.DataHandling.Models;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.HttpManager;
using Newtonsoft.Json.Linq;

namespace ApiProject.DndApiServices.Services
{
    public class DndClassService : Services, IService
    {
        public DTO<DndClassObject> DndClassDTO { get; set; }
        public string DndClassResponse;

        public DndClassService()
        {
            CallManager = new CallManager();
            DndClassDTO = new DTO<DndClassObject>();
        }

        public async Task MakeRequestAsync(string section, string subsection)
        {
            DndClassResponse = await CallManager.MakeARequestAsync(section, subsection);
            JsonResponse = JObject.Parse(DndClassResponse);
            DndClassDTO.DeserializeResponse(DndClassResponse);
        }
    }
}

