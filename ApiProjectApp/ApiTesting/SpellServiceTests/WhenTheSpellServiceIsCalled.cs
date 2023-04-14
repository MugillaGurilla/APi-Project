using System;
using ApiProject.DndApiServices.Services;

namespace ApiTesting.SpellServiceTests
{
    [Category("Happy")]
    public class WhenTheSpellServiceIsCalled_WithValidSpell
    {
        private SpellService _spell;

        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            _spell = new SpellService();
            await _spell.MakeRequestAsync("spells", "?name=Fireball");
        }

        [Test]
        public void StatusIs200_InJsonResponseHeaders()
        {
            Assert.That(_spell.GetStatusCode(), Is.EqualTo(200));
        }

        [Test]
        public void ContentType_IsJson()
        {
            Assert.That(_spell.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}

