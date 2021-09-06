using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace DockerCompose
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string remoteUrl = "http://localhost:4444/wd/hub";
            var options = new ChromeOptions();
            options.AddAdditionalCapability("version", "", true);
            options.AddAdditionalCapability("platform", "LINUX", true);
            var driver = new RemoteWebDriver(new Uri(remoteUrl), options);
            driver.Manage().Window.Maximize();
            //IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers\chromedriver_win32");
            driver.Url = "https://www.google.com";
            Thread.Sleep(10000);
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            string remoteUrl = "http://localhost:4444/wd/hub";
            var options = new FirefoxOptions();
            options.AddAdditionalCapability("version", "", true);
            options.AddAdditionalCapability("platform", "LINUX", true);
            var driver = new RemoteWebDriver(new Uri(remoteUrl), options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
