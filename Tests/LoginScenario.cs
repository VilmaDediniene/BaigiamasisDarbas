using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    internal class LoginScenario : BaseTest
    {
        [Test]
        public void LoginToPage()
        {
            string username = "t0791759@gmail.com";
            string password = "PatoguPirkti569";

            Login.Open();
            Login.ClickButtonDeclineCookies();
            Login.ClickButtonLogIn();
            Login.EnterUsername(username);
            Login.EnterPassword(password);
            Login.ClickButtonLogIn2();

            Assert.That(Login.LogOffButtonIsVisible(), Is.True);
        }
    }
}