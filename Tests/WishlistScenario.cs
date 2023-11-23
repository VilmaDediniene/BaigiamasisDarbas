using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    internal class WishlistScenario : BaseTest
    {
        [Test]
        public void AddingProductToWishlist()
        {
            string username = "t0791759@gmail.com";
            string password = "PatoguPirkti569";
            string searchPhrase = "Gilus darbas";

            Wishlist.Open();
            Wishlist.ClickButtonDeclineCookies();
            Wishlist.ClickButtonLogIn();
            Wishlist.EnterUsername(username);
            Wishlist.EnterPassword(password);
            Wishlist.ClickButtonLogIn2();
            Wishlist.EnterSearchPhrase(searchPhrase);
            Wishlist.ClickButtonSearch();
            Wishlist.ClickOnBook();
            Wishlist.ClickButtonToWishlist();
            Wishlist.ClosePopUpWindow();
            Wishlist.ClickButtonWishList();

            Assert.That(Wishlist.searchPhraseIsVisible(), Is.True);
        }
    }
}