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
        [Then(@"the response should be in a Json format")]
        public void ThenTheResponseShouldBeInAJsonFormat()
        {
            Assert.That(currentService.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}
