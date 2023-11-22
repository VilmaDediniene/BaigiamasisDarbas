namespace Framework.Pages
{
    public class Wishlist
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.patogupirkti.lt");
        }

        public static void ClickButtonDeclineCookies()
        {
            string locator = "//*[@id='CybotCookiebotDialogBodyButtonDecline']";
            Common.ClickElement(locator);
        }

        public static void ClickButtonLogIn()
        {
            string locator = "//*[contains(@class,'customer-btn')]";
            Common.ClickElement(locator);
        }
        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='pass']";
            Common.SendKeysToElement(locator, password);
        }

        public static void EnterUsername(string username)
        {
            string locator = "//*[@id='email']";
            Common.SendKeysToElement(locator, username);
        }

        public static void ClickButtonLogIn2()
        {
            string locator = "//*[@id='send2']";
            Common.ClickElement(locator);
        }

        public static void EnterSearchPhrase(string searchPhrase)
        {
            string locator = "//*[@id='search']";
            Common.SendKeysToElement(locator, searchPhrase);
        }

        public static void ClickButtonSearch()
        {
        string locator = "//*[@id='search_mini_form']";
        Common.ClickElement(locator);
        }
        public static void ClickOnBook()
        {
            string locator = "//a[contains(@href,’gilus-darbass’)] and text()='Į norų sąrašą']";
            Common.ClickElement(locator);
        }
        public static void ClickButtonToWishlist()
        {
            string locator = "//*[@id='product_addtocart_form']";
            Common.ClickElement(locator);
        }

        public static void ClosePopUpWindow()
        {
            string locator = "//*[@id='globalModal']";
            Common.ClickElement(locator);
        }

        public static void ClickButtonWishList()
        {
            string locator = "//*[contains(@class,'icon-bookmark')]";
            Common.ClickElement(locator);
        }

        public static bool searchPhraseIsVisible()
        {
            string locator = "//*[@id='item_137314']";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }
    }
}