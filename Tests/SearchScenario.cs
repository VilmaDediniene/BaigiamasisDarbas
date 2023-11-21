using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.BaseTests;

namespace Tests
{
    internal class SearchScenario : BaseTest
    {
        [Test]
        public void SearchInPatoguPirkti()
        {
            string expectedResult = "Kakė makė - „PatoguPirkti“ paieška";
            string username = "t0791759@gmail.com";
            string password = "PatoguPirkti569";
            string searchPhrase = "Kakė makė";

            SearchPage.Open();
            SearchPage.ClickButtonDeclineCookies();
            SearchPage.ClickButtonLogIn();
            SearchPage.EnterUsername(username);
            SearchPage.EnterPassword(password);
            SearchPage.ClickButtonLogIn2();
            SearchPage.EnterSearchPhrase(searchPhrase);
            SearchPage.ClickButtonSearch();
            string actualResult = Driver.GetPageTitle();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
    