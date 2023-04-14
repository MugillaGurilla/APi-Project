using System;
using ApiProject.DndApiServices.HttpManager;
using ApiProject.DndApiServices.DataHandling;
using ApiProject.DndApiServices.DataHandling.Models;
using Newtonsoft.Json.Linq;

namespace ApiProject.DndApiServices.Services
{
    public abstract class Services
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string ResponseAsString { get; set; }

        public int GetStatusCode() => (int)CallManager.CallManagerResponse.StatusCode;
        public string GetResponseContentType() => CallManager.CallManagerResponse.Content.Headers.ContentType.MediaType;
    }
}

