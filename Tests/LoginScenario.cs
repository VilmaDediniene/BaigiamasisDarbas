using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Assert.That(Login.LogOffButtonIsVisible);
        }
    }
}