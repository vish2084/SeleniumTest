using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SeleniumTest;
using System;
using System.Threading;

namespace DockerCompose
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        public UnitTest1() : base(Browsers.firefox)
        {

        }   

        [TestMethod]
        public void TestMethod1()
        {
            var driver = InIt();
            driver.Manage().Window.Maximize();
            //IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers\chromedriver_win32");
            driver.Url = "https://www.google.com";
            Thread.Sleep(10000);
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var driver = InIt();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";
            Thread.Sleep(10000);
            driver.Quit();
        }

        [TestMethod]
        public void ConstAndReadTest()
        {
            ConstReadOnlyAndStatic test = new ConstReadOnlyAndStatic();
            ConstReadOnlyAndStatic test1 = new ConstReadOnlyAndStatic(15);
            Console.WriteLine(test1.b);
            Console.ReadLine();
        }

        

    }
}
