using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string locator = "//*[@id=CybotCookiebotDialogBodyButtonDecline]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonLogIn()
        {
            string locator = "//*[@id=top]";
            Common.ClickElement(locator);
        }
        public static void EnterPassword(string password)
        {
            string locator = "//*[@id=pass]";
            Common.ClickElement(locator);
        }

        public static void EnterUsername(string username)
        {
            string locator = "//*[@id=email]";
            Common.ClickElement(locator);
        }

        public static void ClickButtonLogIn2()
        {
            string locator = "//*[@id=send2]";
            Common.ClickElement(locator);
        }

        public static bool LogOffButtonIsVisible()
        {
            string locator = "//*[@id=top]";
            Common.WaitForTheElementToBeVisible(locator);
            return true;
        }
    }
}