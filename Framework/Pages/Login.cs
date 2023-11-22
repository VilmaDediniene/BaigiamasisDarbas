namespace Framework.Pages
{
    public class Login
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

        public static bool LogOffButtonIsVisible()
        {
            string locator = "//*[contains(@class,'customer-btn') and text()='Atsijungti']";
            Common.WaitForTheElementToBeVisible(locator);
            return Common.ElementExists(locator);
        }
    }
}