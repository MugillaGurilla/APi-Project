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
        [Then(@"status code (.*) should be returned")]
        public void ThenStatusCodeShouldBeReturned(int p0)
        {
            Assert.That(currentService.GetStatusCode(), Is.EqualTo(p0));
        }


        
        [Then(@"an error not found should be returned")]
        public async Task ThenAnErrorNotFoundShouldBeReturned()
        {
            Assert.That(await currentService.GetErrorMessageAsync(), Is.EqualTo("{\"error\":\"Not found\"}"));
        }
    }



}