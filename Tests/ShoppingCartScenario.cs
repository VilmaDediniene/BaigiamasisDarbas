using Framework.Pages;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests
{
    internal class ShoppingCartScenario : BaseTest
    {
        [Test]
        public void AddingProductToShoppingCart()
        {
            string username = "t0791759@gmail.com";
            string password = "PatoguPirkti569";
            string searchPhrase = "Pasakų knygelių advento kalendorius";

            ShoppingCart.Open();
            ShoppingCart.ClickButtonDeclineCookies();
            ShoppingCart.ClickButtonLogIn();
            ShoppingCart.EnterUsername(username);
            ShoppingCart.EnterPassword(password);
            ShoppingCart.ClickButtonLogIn2();
            ShoppingCart.EnterSearchPhrase(searchPhrase);
            ShoppingCart.ClickButtonSearch();
            ShoppingCart.ClickButtonAddtoCart();
            ShoppingCart.ClickButtonBuy();

            Assert.That(ShoppingCart.searchPhraseIsVisible(), Is.True);
        }
    }
}
