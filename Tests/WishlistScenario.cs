using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class WishlistScenario
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



        }
    }
}
