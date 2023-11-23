namespace Framework.Pages
{
    public class ShoppingCart
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
       
        public static void ClickButtonAddtoCart()
        {
            string locator = "//*[contains(@class,'btn-primary line-height-40 mt10') and text()='Į krepšelį']";
            //string locator = "/html/body/div[3]/div[2]/div[4]/div/div[2]/div[1]/form/a";
            Common.ClickElement(locator);
        }
        public static void ClickButtonBuy()
        {
            string locator = "//*[contains(@class,'btn-primary block') and text()='Pirkti']";
            //string locator = "/html/body/div[4]/div/div/div[3]/div/div[2]/a";
            Common.ClickElement(locator);
        }

            public static bool searchPhraseIsVisible()
        {
            string locator = "//a[contains(@href,’pasaku-knygeliu-advento-kalendorius’)] and text()='Pasakų knygelių advento kalendorius']";
            //string locator = "/html/body/div[3]/form/div/div[4]/div[2]/div[1]/h4/a";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }        
    }
}