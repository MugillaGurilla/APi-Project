using System;
namespace ApiProject.DndApiServices.Services
{
	public interface IService
	{
        async Task MakeRequestAsync(string section, string subsection)
        {

        }
        int GetStatusCode();
        string GetResponseContentType();
        async Task<string> GetErrorMessageAsync()
        {
            return "0";
        }

    }
}

