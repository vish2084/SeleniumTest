using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerCompose
{
    [TestClass]
    public class WindowHandlesCode
    {
        [TestMethod]
        public void windowhandler()
        {
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/browser-windows";

            // Title
            string title = driver.Title;

            // Window Handles
            string currentWindow = driver.CurrentWindowHandle;
            IWebElement ele = driver.FindElement(By.Id("windowButton"));
            ele.Click();
            IReadOnlyCollection<string> allWin = driver.WindowHandles;
            foreach (var window in allWin)
            {
                if (!window.Equals(currentWindow))
                {
                    driver.SwitchTo().Window(window);
                    IWebElement newWinHeading = driver.FindElement(By.XPath("//h1[@id='sampleHeading']"));
                    Assert.IsTrue(newWinHeading.Displayed);
                }
            }
            driver.SwitchTo().Window(currentWindow);






        }
    }
}
