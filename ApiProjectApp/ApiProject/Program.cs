namespace ApiProject;
using ApiProject.DndApiServices.Services;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main(string[] args)
    {
        Services Services = new Services();
        IService currentService;
        currentService = Services.MakeAServices("classes");
        currentService.MakeRequestAsync("classes", "paladin");
        currentService.GetHeaders();
    }
}

