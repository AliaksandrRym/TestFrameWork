
namespace UIGlobalQATests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using TestFrameWork.DriverCore;
    using UiGlobalQAPart;

    [TestClass]
    public class BaseTest
    {
        [TestCleanup]
        public void CleanUp()
        {
            Browser.Driver.Quit();
        }

        protected GlobalsqaHomePage OpenHomePage()
        {
            Browser.Driver.Navigate().GoToUrl(Configuration.StartUrl);
            return (GlobalsqaHomePage)Activator.CreateInstance(typeof(GlobalsqaHomePage));
        }
    }
}
