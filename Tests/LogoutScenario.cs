using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    internal class LogoutScenario : BaseTest
    {
        [Test]
        public void LogoutFromPage()
        {
            string username = "t0791759@gmail.com";
            string password = "PatoguPirkti569";

            Logout.Open();
            Logout.ClickButtonDeclineCookies();
            Logout.ClickButtonLogIn();
            Logout.EnterUsername(username);
            Logout.EnterPassword(password);
            Logout.ClickButtonLogIn2();
            Logout.ClickButtonLogout();

            Assert.That(Logout.LogInButtonIsVisible(), Is.True);
        }
    }
}
