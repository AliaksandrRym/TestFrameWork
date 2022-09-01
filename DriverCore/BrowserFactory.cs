
using AllStarsSolution.WebDrivers;
using OpenQA.Selenium;
using System;
using TestFrameWork.Enums;

namespace TestFrameWork.DriverCore
{
    class BrowserFactory
    {
        public static IWebDriver GetDriver(Browsers type)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case Browsers.Chrome:
                    {
                        driver = new ChromeDriverCreator().CreateWebDriver();
                        break;
                    }
                case Browsers.FireFox:
                    {
                        throw new NotImplementedException("Create Firefox driver is not implemented");
                    }
                default:
                    {
                        throw new Exception("Unknown browser type!");
                    }
            }
            return driver;
        }

    }
}
