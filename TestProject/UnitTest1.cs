using GlushkovCinemaApp;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Auth1()
        {
            var ex = new List<Users> { new Users { password = "11", username = "failure" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth2()
        {
            var ex = new List<Users> { new Users { password = "111", username = "admin" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(true));
        }
        [Test]
        public async Task Auth3()
        {
            var ex = new List<Users> { new Users { password = "1", username = "54" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth4()
        {
            var ex = new List<Users> { new Users { password = "121", username = "ex" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth5()
        {
            var ex = new List<Users> { new Users { password = "134", username = "fa" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth6()
        {
            var ex = new List<Users> { new Users { password = "211", username = "ure" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth7()
        {
            var ex = new List<Users> { new Users { password = "411", username = "lure" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth8()
        {
            var ex = new List<Users> { new Users { password = "6711", username = "ahah" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth9()
        {
            var ex = new List<Users> { new Users { password = "234", username = "testing is fun :^)" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth10()
        {
            var ex = new List<Users> { new Users { password = "11234", username = "e34" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth11()
        {
            var ex = new List<Users> { new Users { password = "151", username = "211" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth12()
        {
            var ex = new List<Users> { new Users { password = "1432", username = "f234i" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth13()
        {
            var ex = new List<Users> { new Users { password = "user1", username = "user1" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(true));
        }
        [Test]
        public async Task Auth14()
        {
            var ex = new List<Users> { new Users { password = "12341", username = "fa2134" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth15()
        {
            var ex = new List<Users> { new Users { password = "1ww1", username = "fgfh" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth16()
        {
            var ex = new List<Users> { new Users { password = "osujdayu", username = "vtornikkk" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }
        [Test]
        public async Task Auth17()
        {
            var ex = new List<Users> { new Users { password = "xd", username = "xdddddd" } };
            Assert.That(await AuthPage.UserPost(ex[0]), Is.EqualTo(false));
        }

    }
}