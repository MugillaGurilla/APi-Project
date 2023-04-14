using System;
using Newtonsoft.Json;

namespace ApiProject.DndApiServices.DataHandling
{
    public class DTO<T> where T : IResponse, new()
    {
        // DtoResponse is a generic object, could be of type MonsterResponse,
        // SpellResponse or any other model.
        public T DtoResponse { get; set; }

        public void DeserializeResponse(string response)
        {
            DtoResponse = JsonConvert.DeserializeObject<T>(response);
        }
    }
}

