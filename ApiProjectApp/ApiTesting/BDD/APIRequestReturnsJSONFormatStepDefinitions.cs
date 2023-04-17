using ApiProject.DndApiServices.Services;
using ApiTesting.Utils;
using System;
using TechTalk.SpecFlow;

namespace ApiTesting.BDD
{
    [Binding]
    [Scope(Feature = "APIRequestReturnsJSONFormat")]
    public class APIRequestReturnsJSONFormatStepDefinitions : SharedSteps
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

        [Then(@"the response should be in a Json format")]
        public void ThenTheResponseShouldBeInAJsonFormat()
        {
            Assert.That(currentService.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}
