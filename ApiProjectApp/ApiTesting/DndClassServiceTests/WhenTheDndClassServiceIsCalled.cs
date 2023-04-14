using System;
using ApiProject.DndApiServices.Services;

namespace ApiTesting.DndClassServiceTests
{
    [Category("Happy")]
    public class WhenTheDndClassServiceIsCalled
    {
        private DndClassService _dndClass;

        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            _dndClass = new DndClassService();
            await _dndClass.MakeRequestAsync("classes", "paladin");
        }

        [Test]
        public void StatusIs200_InJsonResponseHeaders()
        {
            Assert.That(_dndClass.GetStatusCode(), Is.EqualTo(200));
        }

        [Test]
        public void ContentType_IsJson()
        {
            Assert.That(_dndClass.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}

