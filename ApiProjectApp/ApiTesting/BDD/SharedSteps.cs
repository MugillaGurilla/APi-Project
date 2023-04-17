using ApiProject.DndApiServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ApiTesting.BDD
{
    public class SharedSteps
    {
        public Services Services;
        public IService currentService;

        [Given(@"that I have initialised a DnD 5E API service")]
        public void GivenThatIHaveInitialisedADnD5EAPIService()
        {
            Services = new Services();
        }

        [When(@"I execute the request with (.*), (.*)")]
        public async Task WhenIExecuteTheRequestWithAsync(string section, string subsection)
        {
            currentService = Services.MakeAServices(section);
            await currentService.MakeRequestAsync(section, subsection);
        }
    }
}
