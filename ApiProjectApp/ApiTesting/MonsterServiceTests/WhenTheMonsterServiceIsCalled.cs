using System;
using NUnit.Framework;
using ApiProject.DndApiServices.Services;

namespace ApiTesting.MonsterServiceTests
{
	[Category("Happy")]
	public class WhenTheMonsterServiceIsCalled_WithAValidMonster
	{
		private MonsterService _monster;

		[OneTimeSetUp]
		public async Task OneTimeSetup()
		{
			_monster = new MonsterService();
			await _monster.MakeRequestAsync("monsters", "adult-black-dragon");
		}

        [Test]
        public void StatusIs200_InJsonResponseHeaders()
        {
            Assert.That(_monster.GetStatusCode(), Is.EqualTo(200));
        }

        [Test]
        public void ContentType_IsJson()
        {
            Assert.That(_monster.GetResponseContentType(), Is.EqualTo("application/json"));
        }
    }
}

