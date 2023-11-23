using Framework;
using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    internal class SearchScenario : BaseTest
    {
        [Test]
        public void SearchInPatoguPirkti()
        {
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

            Assert.That(SearchPage.SearchPhraseIsVisible(), Is.True);
        }
    }
}