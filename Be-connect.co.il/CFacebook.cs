using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_connect.co.il
{
    class CFacebook
    {
        // Create googleChrome
        public IWebDriver googleChrome()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("disable-infobars");               //disable test automation message
            option.AddArguments("--disable-notifications");        //disable notifications
            option.AddArguments("--disable-web-security");         //disable save password windows
            option.AddUserProfilePreference("credentials_enable_service", false);

            option.AddUserProfilePreference("browser.download.manager.showWhenStarting", false);
            option.AddUserProfilePreference("browser.helperApps.neverAsk.saveToDisk", "text/csv");
            option.AddUserProfilePreference("disable-popup-blocking", "true");
            option.AddUserProfilePreference("safebrowsing.enabled", true);
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(driverService, option);
            return driver;
        }
        // facebook login
        public void facebookLogin(IWebDriver driver, string username, string password)
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                System.Threading.Thread.Sleep(500);
                driver.FindElement(By.Id("email")).SendKeys(username);
                driver.FindElement(By.Id("pass")).SendKeys(password);
                driver.FindElement(By.Id("loginbutton")).Click();
                System.Threading.Thread.Sleep(500);
            }
            catch (Exception)
            {
            }
        }
        // new tab
        public void newTab(IWebDriver driver, string url)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.open('')");
            driver.SwitchTo().Window(driver.WindowHandles[driver.WindowHandles.Count - 1]);
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception)
            {
            }
            System.Threading.Thread.Sleep(1000);
        }
        // goto url
        public void gotoUrl(IWebDriver driver, string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception)
            {
            }
            System.Threading.Thread.Sleep(1000);
        }
        // click likepage button
        public void likePage(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.XPath("//button[@class='likeButton _4jy0 _4jy4 _517h _51sy _42ft']")).Click();
                new CFormControl().FormText("Success");
            }
            catch (Exception)
            {
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
