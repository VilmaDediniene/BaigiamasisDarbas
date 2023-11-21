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
    internal class ShoppingCartScenario : BaseTest
    {
        private object actualResult;

        [Test]
        public void AddingProductToShoppingCart()
        {
            string expectedResult = "Pasakų knygelių advento kalendorius";
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

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
