using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;


namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IInterfaceOne i = new ChildClass();
            i.Add();
            string remoteUrl = "http://localhost:4446/wd/hub";

            var options = new ChromeOptions();
            options.AddAdditionalCapability("version", "", true);
            options.AddAdditionalCapability("platform", "LINUX", true);
            var driver = new RemoteWebDriver(new Uri(remoteUrl), options);
            driver.Manage().Window.Maximize();
            //IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers\chromedriver_win32");
            driver.Url = "https://www.google.com";
            driver.Quit();
        }

        [TestMethod]
        public void ConstRead()
        {
            ConstReadOnlyAndStatic constRead = new ConstReadOnlyAndStatic();
            ConstReadOnlyAndStatic constRead2 = new ConstReadOnlyAndStatic();
            Console.WriteLine(constRead2.b);
        }
    }
}
