using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace FluxdayIO_ATQC
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class UbuntuSelenoidTest
    {
        private IWebDriver driverChrome70 = null;
        private IWebDriver driverChrome69 = null;
        private IWebDriver driverFirefox62 = null;
        private IWebDriver driverFirefox63 = null;
        private IWebDriver driverOpera55 = null;
        private IWebDriver driverOpera56 = null;



        [OneTimeSetUp]
        public void BeforeAllMethods()
        {

        }

        [SetUp]
        public void SetUp()
        {

        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {

        }

        [Test]
        public void TestChrome70()
        {
            var capabilitiesChrome70 = new DesiredCapabilities("chrome", "70.0", new Platform(PlatformType.Any));
            //capabilitiesChrome70.SetCapability("enableVNC", true);
            driverChrome70 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesChrome70);
            //driverChrome70.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverChrome70.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverChrome70.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");


            driverChrome70.FindElement(By.Id("user_email")).Click();
            driverChrome70.FindElement(By.Id("user_email")).Clear();
            driverChrome70.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");

            driverChrome70.FindElement(By.Id("user_password")).Click();
            driverChrome70.FindElement(By.Id("user_password")).Clear();
            driverChrome70.FindElement(By.Id("user_password")).SendKeys("password");

            driverChrome70.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverChrome70.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);

            driverChrome70.Quit();
        }

        [Test]
        public void TestChrome69()
        {
            var capabilitiesChrome69 = new DesiredCapabilities("chrome", "69.0", new Platform(PlatformType.Any));
            //capabilitiesChrome69.SetCapability("enableVNC", true);
            driverChrome69 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesChrome69);
            //driverChrome69.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverChrome69.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverChrome69.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");

            driverChrome69.FindElement(By.Id("user_email")).Click();
            driverChrome69.FindElement(By.Id("user_email")).Clear();
            driverChrome69.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");

            driverChrome69.FindElement(By.Id("user_password")).Click();
            driverChrome69.FindElement(By.Id("user_password")).Clear();
            driverChrome69.FindElement(By.Id("user_password")).SendKeys("password");

            driverChrome69.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverChrome69.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);

            driverChrome69.Quit();
        }

        [Test]
        public void TestFirefox62()
        {
            var capabilitiesFirefox62 = new DesiredCapabilities("firefox", "62.0", new Platform(PlatformType.Any));
            //capabilitiesFirefox62.SetCapability("enableVNC", true);
            driverFirefox62 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesFirefox62);
            //driverFirefox62.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverFirefox62.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverFirefox62.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");

            driverFirefox62.FindElement(By.Id("user_email")).Click();
            driverFirefox62.FindElement(By.Id("user_email")).Clear();
            driverFirefox62.FindElement(By.Id("user_email")).SendKeys("emp1@fluxday.io");

            driverFirefox62.FindElement(By.Id("user_password")).Click();
            driverFirefox62.FindElement(By.Id("user_password")).Clear();
            driverFirefox62.FindElement(By.Id("user_password")).SendKeys("password");

            driverFirefox62.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverFirefox62.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);

            driverFirefox62.Quit();
        }

        [Test]
        public void TestFirefox63()
        {
            var capabilitiesFirefox63 = new DesiredCapabilities("firefox", "63.0", new Platform(PlatformType.Any));
            //capabilitiesFirefox63.SetCapability("enableVNC", true);
            driverFirefox63 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesFirefox63);
            //driverFirefox63.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverFirefox63.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverFirefox63.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            
            driverFirefox63.FindElement(By.Id("user_email")).Click();
            driverFirefox63.FindElement(By.Id("user_email")).Clear();
            driverFirefox63.FindElement(By.Id("user_email")).SendKeys("emp1@fluxday.io");

            driverFirefox63.FindElement(By.Id("user_password")).Click();
            driverFirefox63.FindElement(By.Id("user_password")).Clear();
            driverFirefox63.FindElement(By.Id("user_password")).SendKeys("password");

            driverFirefox63.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverFirefox63.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);

            driverFirefox63.Quit();
        }

        //[Test]
        public void TestOpera55()
        {
            var capabilitiesOpera55 = new DesiredCapabilities("opera", "55.0", new Platform(PlatformType.Any));
            //capabilitiesOpera55.SetCapability("enableVNC", true);
            driverOpera55 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesOpera55);
            //driverOpera55.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverOpera55.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverOpera55.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");

            driverOpera55.FindElement(By.Id("user_email")).Click();
            driverOpera55.FindElement(By.Id("user_email")).Clear();
            driverOpera55.FindElement(By.Id("user_email")).SendKeys("emp2@fluxday.io");

            driverOpera55.FindElement(By.Id("user_password")).Click();
            driverOpera55.FindElement(By.Id("user_password")).Clear();
            driverOpera55.FindElement(By.Id("user_password")).SendKeys("password");

            driverOpera55.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverOpera55.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);
            
            driverOpera55.Quit();
        }

        //[Test]
        public void TestOpera56()
        {
            var capabilitiesOpera56 = new DesiredCapabilities("opera", "56.0", new Platform(PlatformType.Any));
            //capabilitiesOpera56.SetCapability("enableVNC", true);
            driverOpera56 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilitiesOpera56);
            //driverOpera56.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driverOpera56.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driverOpera56.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            
            driverOpera56.FindElement(By.Id("user_email")).Click();
            driverOpera56.FindElement(By.Id("user_email")).Clear();
            driverOpera56.FindElement(By.Id("user_email")).SendKeys("emp2@fluxday.io");

            driverOpera56.FindElement(By.Id("user_password")).Click();
            driverOpera56.FindElement(By.Id("user_password")).Clear();
            driverOpera56.FindElement(By.Id("user_password")).SendKeys("password");

            driverOpera56.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();

            Assert.AreEqual("+Task",
                driverOpera56.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);
            driverOpera56.Quit();
        }
    }
}
