namespace Framework.Pages
{
    public class SearchPage
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

        public static void EnterUsername(string username)
        {
            string locator = "//*[@id='email']";
            Common.SendKeysToElement(locator, username);
        }

        public static void EnterPassword(string password)
        {
            string locator = "//*[@id='pass']";
            Common.SendKeysToElement(locator, password);
        }

        public static void ClickButtonLogIn2()
        {
            string locator = "//*[@id='send2']";
            Common.ClickElement(locator);
        }

        public static void EnterSearchPhrase(string phrase)
        {
            string locator = "//*[@id='search']";
            Common.SendKeysToElement(locator, phrase);
        }

        public static void ClickButtonSearch()
        {
            string locator = "//*[@id='search_mini_form']";
            Common.ClickElement(locator);
        }

        public static bool SearchPhraseIsVisible()
        {
            //string locator = "//a[contains(@href,’zaidimas-dobble-kake-make’)] and text()='Kakė Makė']";
            string locator = "/html/body/div[3]/div/div[3]/div[2]/div[2]/div/div[2]/a";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }
    }
}