using System;
using TechTalk.SpecFlow;
using ApiProject.DndApiServices.Services;
using ApiTesting.Utils;
using TechTalk.SpecFlow.Assist;
using static System.Collections.Specialized.BitVector32;

namespace ApiTesting.BDD
{
    [Scope(Feature = "APIRequestReturnsStatusCode")]
    [Binding]
    public class APIRequestReturnsStatusCodeStepDefinitions : SharedSteps
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


        [Then(@"status code (.*) should be returned")]
        public void ThenStatusCodeShouldBeReturned(int p0)
        {
            Assert.That(currentService.GetStatusCode(), Is.EqualTo(p0));
        }





    }

}