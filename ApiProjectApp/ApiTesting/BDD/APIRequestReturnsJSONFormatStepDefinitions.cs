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
        public MonsterService _monster;

        private Specifications _specifications;

        [Given(@"that I have initialised a DnD 5E API service")]
        public void GivenThatIHaveInitialisedADnD5EAPIService()
        {
            _monster = new MonsterService();
        }

        [When(@"I execute the request with (.*), (.*)")]
        public async Task WhenIExecuteTheRequestWithAsync(string section, string subsection)
        {
            await _monster.MakeRequestAsync(section, subsection);
        }

        [Then(@"the response should be in a Json format")]
        public void ThenTheResponseShouldBeInAJsonFormat()
        {
            Assert.That(_monster.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}
