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


        [Then(@"status code (.*) should be returned")]
        public void ThenStatusCodeShouldBeReturned(int p0)
        {
            Assert.That(_monster.GetStatusCode(), Is.EqualTo(p0));
        }





    }

}