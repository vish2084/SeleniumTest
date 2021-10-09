using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerCompose
{
    public class BaseTest
    {
        private Browsers type;

        public BaseTest(Browsers browsers)
        {
            type = browsers;
        }

        public IWebDriver InIt()
        {

            string remoteUrl = "http://localhost:4444/wd/hub";
            if (type == Browsers.Chrome)
            {
                var options = new ChromeOptions();
                options.AddAdditionalCapability("version", "", true);
                options.AddAdditionalCapability("platform", "LINUX", true);
                return new RemoteWebDriver(new Uri(remoteUrl), options);
            }
            else
            {
                var options = new FirefoxOptions();
                options.AddAdditionalCapability("version", "", true);
                options.AddAdditionalCapability("platform", "LINUX", true);
                return new RemoteWebDriver(new Uri(remoteUrl), options);
            }
        }

        public enum Browsers
        {
            Chrome,
            firefox
        }
    }
}
