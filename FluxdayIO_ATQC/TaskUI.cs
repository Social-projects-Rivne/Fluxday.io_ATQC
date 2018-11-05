using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace FluxdayIO_ATQC
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TaskUI
    {
        private IWebDriver driver1 = null;
        private IWebDriver driver2 = null;
        private IWebDriver driver3 = null;
        private IWebDriver driver4 = null;
        private IWebDriver driver5 = null;


        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            //driver = new ChromeDriver(Environment.CurrentDirectory);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var capabilities1 = new DesiredCapabilities("chrome", "69.0", new Platform(PlatformType.Any));
            //capabilities1.SetCapability("enableVNC", true);
            //driver1 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilities1);
            //driver1.Manage().Window.Size = new System.Drawing.Size(1920, 1080); //(new Dimension(1920, 1080));
            //driver1.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var capabilities2 = new DesiredCapabilities("chrome", "69.0", new Platform(PlatformType.Any));
            //capabilities2.SetCapability("enableVNC", true);
            //driver2 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilities2);
            //driver2.Manage().Window.Size = new System.Drawing.Size(1920, 1080); //(new Dimension(1920, 1080));
            //driver2.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var capabilities3 = new DesiredCapabilities("firefox", "61.0", new Platform(PlatformType.Any));
            //capabilities3.SetCapability("enableVNC", true);
            //driver3 = new RemoteWebDriver(new Uri("http://172.17.0.1:4444/wd/hub"), capabilities3);
            //driver3.Manage().Window.Size = new System.Drawing.Size(1920, 1080); //(new Dimension(1920, 1080));
            //driver3.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var capabilities4 = new DesiredCapabilities("firefox", "62.0", new Platform(PlatformType.Any));
            //capabilities4.SetCapability("enableVNC", true);
            //driver4 = new RemoteWebDriver(new Uri("http://172.22.84.113:4444/wd/hub"), capabilities4);
            //driver4.Manage().Window.Size = new System.Drawing.Size(1920, 1080); //(new Dimension(1920, 1080));
            //driver4.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //var capabilities5 = new DesiredCapabilities("chrome", "70.0", new Platform(PlatformType.Any));
            //capabilities5.SetCapability("enableVNC", true);
            //driver5 = new RemoteWebDriver(new Uri("http://172.22.84.113:4444/wd/hub"), capabilities5);
            //driver5.Manage().Window.Size = new System.Drawing.Size(1920, 1080); //(new Dimension(1920, 1080));
            //driver5.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp]
        public void SetUp()
        {
            //driver1.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            //driver2.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            //driver3.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            //driver4.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            //driver5.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");

            //Thread.Sleep(4000);
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            //driver1.Quit();
            //driver2.Quit();
            //driver3.Quit();
            //driver4.Quit();
            //driver5.Quit();

        }

        //[Test]
        public void FirstTest1()
        {
            Console.WriteLine("Start test");
            Thread.Sleep(20000);

            driver1.FindElement(By.Id("user_email")).Click();
            driver1.FindElement(By.Id("user_email")).Clear();
            driver1.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");
            Thread.Sleep(4000);

            driver1.FindElement(By.Id("user_password")).Click();
            driver1.FindElement(By.Id("user_password")).Clear();
            driver1.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");
            Thread.Sleep(4000);


            driver1.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver1.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text,"[OK]");
            Thread.Sleep(4000);

            Console.WriteLine("Assert [ok]");

        }

        //[Test]
        public void FirstTest2()
        {
            Console.WriteLine("Start test");
            Thread.Sleep(20000);

            driver3.FindElement(By.Id("user_email")).Click();
            driver3.FindElement(By.Id("user_email")).Clear();
            driver3.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");
            Thread.Sleep(4000);

            driver3.FindElement(By.Id("user_password")).Click();
            driver3.FindElement(By.Id("user_password")).Clear();
            driver3.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");
            Thread.Sleep(4000);


            driver3.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver3.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text, "[OK]");
            Thread.Sleep(4000);

            Console.WriteLine("Assert [ok]");

        }

        //[Test]
        public void FirstTest3()
        {
            Console.WriteLine("Start test");
            Thread.Sleep(20000);

            driver2.FindElement(By.Id("user_email")).Click();
            driver2.FindElement(By.Id("user_email")).Clear();
            driver2.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");
            Thread.Sleep(4000);

            driver2.FindElement(By.Id("user_password")).Click();
            driver2.FindElement(By.Id("user_password")).Clear();
            driver2.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");
            Thread.Sleep(4000);


            driver2.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver2.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text, "[OK]");
            Thread.Sleep(4000);

            Console.WriteLine("Assert [ok]");
        }

        //[Test]
        public void FirstTest4()
        {
            Console.WriteLine("Start test");
            Thread.Sleep(20000);

            driver4.FindElement(By.Id("user_email")).Click();
            driver4.FindElement(By.Id("user_email")).Clear();
            driver4.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");
            Thread.Sleep(4000);

            driver4.FindElement(By.Id("user_password")).Click();
            driver4.FindElement(By.Id("user_password")).Clear();
            driver4.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");
            Thread.Sleep(4000);


            driver4.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver4.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text, "[OK]");
            Thread.Sleep(4000);

            Console.WriteLine("Assert [ok]");
        }

        //[Test]
        public void FirstTest5()
        {
            Console.WriteLine("Start test");
            Thread.Sleep(20000);

            driver5.FindElement(By.Id("user_email")).Click();
            driver5.FindElement(By.Id("user_email")).Clear();
            driver5.FindElement(By.Id("user_email")).SendKeys("lead@fluxday.io");
            Console.WriteLine("Field user name fill [ok]");
            Thread.Sleep(4000);

            driver5.FindElement(By.Id("user_password")).Click();
            driver5.FindElement(By.Id("user_password")).Clear();
            driver5.FindElement(By.Id("user_password")).SendKeys("password");
            Console.WriteLine("Field user password fill [ok]");
            Thread.Sleep(4000);


            driver5.FindElement(By.CssSelector("#new_user > div.set > div.field-login > button")).Click();
            Thread.Sleep(4000);

            Assert.AreEqual("+Task",
                driver5.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text, "[OK]");
            Thread.Sleep(4000);

            Console.WriteLine("Assert [ok]");
        }
    }
}
