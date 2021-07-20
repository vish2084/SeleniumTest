using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers\chromedriver_win32");
            driver.Url = "https://www.google.com";
            driver.Quit();
        }
    }
}
