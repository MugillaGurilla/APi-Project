using System;
using System.Configuration;

namespace ApiProject.DndApiServices
{
	public class AppConfigReader
	{
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];

    }
}

