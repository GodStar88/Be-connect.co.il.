using Be_connect.co.il.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void facebookLogout(IWebDriver driver)
        {
            driver.FindElement(By.Id("userNavigationLabel")).Click();
            Thread.Sleep(2000);
            try
            {
                buttonClick(driver, "//div[@class='uiScrollableAreaContent']//a", "Log out");
            }
            catch (Exception)
            {
                //buttonClick(driver, "//div[@class='uiScrollableAreaContent']//a", "Log Out");
                driver.FindElement(By.XPath("//li[@class='_54ni navSubmenu __MenuItem']")).Click();
            }
            Thread.Sleep(500);
            driver.FindElement(By.Id("email")).SendKeys(Keys.Control + "a"); ;
            Thread.Sleep(500);
            driver.FindElement(By.Id("email")).SendKeys(Keys.Delete);
            Thread.Sleep(500);
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
        // Post in group
        public void groupPost(IWebDriver postDriver, string write)
        {

            System.Threading.Thread.Sleep(500);
            // click 'Write Post' and input post text
            try
            {
                postDriver.FindElement(By.XPath("//span[@class='uiIconText _5qtp']")).Click();
                System.Threading.Thread.Sleep(8000);
            }
            catch (Exception) { }
            try
            {
                postDriver.FindElement(By.XPath("//div[@class='notranslate _5rpu']")).SendKeys(Environment.NewLine + write);
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception)
            {
                try
                {
                    System.Threading.Thread.Sleep(1000);
                    postDriver.FindElement(By.XPath("//div[@data-testid='status-attachment-mentions-input']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    postDriver.FindElement(By.XPath("//div[@data-testid='status-attachment-mentions-input']")).SendKeys(Environment.NewLine + write);
                    System.Threading.Thread.Sleep(3000);
                }
                catch (Exception)
                {
                }
            }
            // upload video                    
            try
            {
                IWebElement fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='media-sprout']"));
                Thread.Sleep(1000);
                fileUpload.SendKeys(Settings.Default["videoFile"].ToString());
                while (true)
                {
                    try { fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='media-sprout']")); } catch (Exception) { }
                    Thread.Sleep(500);
                    break;
                }
            }
            catch (Exception) { }
            // upload image   
            try
            {
                IWebElement fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='media-sprout']"));
                System.Threading.Thread.Sleep(1000);
                fileUpload.SendKeys(Settings.Default["imageList"].ToString());
                while (true)
                {
                    try { fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='media-sprout']")); } catch (Exception) { }
                    System.Threading.Thread.Sleep(500);
                    break;
                }
            }
            catch (Exception) { }

            // post button click
            int count = 0;
            while (true)
            {
                if (count > 20) break;
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    postDriver.FindElement(By.XPath("//button[@class = '_1mf7 _4jy0 _4jy3 _4jy1 _51sy selected _42ft']")).Click();
                    System.Threading.Thread.Sleep(3000);
                    break;
                }
                catch (Exception)
                {
                    count++;
                }
                System.Threading.Thread.Sleep(3000);
            }
            new CFormControl().FormText("Success");
            System.Threading.Thread.Sleep(3000);
        }
        // Post in page
        public void pagePost(IWebDriver postDriver, string write)
        {
            try
            {
                var buttons = postDriver.FindElements(By.XPath("//span[@class='_2yav']"));
                foreach (var item in buttons)
                {
                    if (item.Text == "Posts")
                    {
                        item.Click();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            System.Threading.Thread.Sleep(3000);
            // click 'Write Post' and input post text

            try
            {
                postDriver.FindElement(By.XPath("(//span[@class='_5qtp'])[2]")).Click();
                System.Threading.Thread.Sleep(10000);
            }
            catch (Exception) { }
            try
            {
                postDriver.FindElement(By.XPath("//div[@class='_5yk2']")).Click();
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception) { }
            try
            {
                postDriver.FindElement(By.XPath("//div[@class='_5yk2']")).SendKeys(Environment.NewLine + write);
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }

            // upload video   
            try
            {
                IWebElement fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='add-more-photos']"));
                System.Threading.Thread.Sleep(1000);
                fileUpload.SendKeys(Settings.Default["videoFile"].ToString());
                while (true)
                {
                    try { fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='add-more-photos']")); } catch (Exception) { }
                    System.Threading.Thread.Sleep(500);
                    break;
                }
            }
            catch (Exception) { }

            // upload image   
            try
            {
                IWebElement fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='add-more-photos']"));
                System.Threading.Thread.Sleep(1000);
                fileUpload.SendKeys(Settings.Default["imageList"].ToString());
                while (true)
                {
                    try { fileUpload = postDriver.FindElement(By.XPath("//input[@data-testid='add-more-photos']")); } catch (Exception) { }
                    System.Threading.Thread.Sleep(500);
                    break;
                }
            }
            catch (Exception) { }

            // post button click
            int count = 0;
            while (true)
            {
                if (count > 20) break;
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    postDriver.FindElement(By.XPath("//button[@class = '_1mf7 _4jy0 _4jy3 _4jy1 _51sy selected _42ft']")).Click();
                    System.Threading.Thread.Sleep(3000);
                    break;
                }
                catch (Exception)
                {
                    count++;
                }
                System.Threading.Thread.Sleep(3000);
            }
            new CFormControl().FormText("Success");
            System.Threading.Thread.Sleep(3000);
        }
        // join event
        public void joinEvent(IWebDriver driver)
        {
            try
            {
                new CFormControl().FormText("Attending events");
                buttonClick(driver, "//a[@class='_42ft _4jy0 _i8v _4jy4 _517h _51sy']", "Going");
            }
            catch (Exception)
            {
            }
            new CFormControl().FormText("Success");
            System.Threading.Thread.Sleep(3000);
        }
        // Like comments
        public void likeComments(IWebDriver driver, bool comments)
        {
            buttonClickAll(driver, "//a[@class='UFILikeLink _4x9- _4x9_ _48-k']", "Like");
            if (comments)
              buttonClickAll(driver, "//a[@class='UFILikeLink UFIReactionLink']", "Like");
            new CFormControl().FormText("Success");
            System.Threading.Thread.Sleep(3000);

        }
        // Invite event
        public void inviteEvent(IWebDriver driver)
        {

            try
            {
                buttonClick(driver, "//span[@class='_55pe']", "Share");
                Thread.Sleep(5000);
                try
                {
                    buttonClick(driver, "//a[@class='_54nc']", "Invite Friends");
                    Thread.Sleep(2000);
                }
                catch (Exception)
                {
                    buttonClick(driver, "//a[@class='_54nc']", "Invite Friends");
                    Thread.Sleep(2000);
                }
                buttonClick(driver, "//div[@class='_ohf rfloat']", "Select All");
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 layerConfirm uiOverlayButton _4jy3 _4jy1 selected _51sy']")).Click();
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }
            new CFormControl().FormText("Success");
            System.Threading.Thread.Sleep(3000);


        }
        public void buttonClick(IWebDriver driver, string element, string txt)
        {
            try
            {
                var buttons = driver.FindElements(By.XPath(element));
                foreach (var item in buttons)
                {
                    if (item.Text.Contains(txt))
                    {
                        item.Click();
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            System.Threading.Thread.Sleep(500);
        }
        public void buttonClickAll(IWebDriver driver, string element, string txt)
        {
            try
            {
                var buttons = driver.FindElements(By.XPath(element));
                foreach (var item in buttons)
                {
                    if (item.Text.Contains(txt))
                    {
                        item.Click();
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }
            catch (Exception)
            {
            }            
        }
        public void pageDown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            System.Threading.Thread.Sleep(1000);
        } 
    }
}
