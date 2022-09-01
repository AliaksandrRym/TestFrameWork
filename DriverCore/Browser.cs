using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrameWork.Enums;

namespace TestFrameWork.DriverCore
{
    public class Browser
    {

        private static IWebDriver driver = null;

        private static Browsers currentBrowser;

        private static string browserName;


        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = BrowserFactory.GetDriver(currentBrowser);
                }
                return driver;
            }
        }

        public Browser()
        {
            InitParams();
        }

        private static void InitParams()
        {
            browserName = Configuration.Browser;
            Enum.TryParse(browserName,  out currentBrowser);
        }

        public static void Quit()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
