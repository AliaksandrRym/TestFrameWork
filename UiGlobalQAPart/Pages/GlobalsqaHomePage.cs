namespace UiGlobalQAPart
{
    using UiGlobalQAPart.Pages;
    using OpenQA.Selenium;
    using TestFrameWork.DriverCore;
    using OpenQA.Selenium.Interactions;

    public class GlobalsqaHomePage: BasePage
    {
        private static readonly By TestersHubOptionLocator = By.Id("menu-item-2822");

        private static readonly By DemoTestingSiteMenuItemLocator = By.Id("menu-item-2823");

        private static readonly By ProgressBarMenuItemLocator = By.Id("menu-item-2832");

        private IWebElement TesterOptions => Browser.Driver.FindElement(TestersHubOptionLocator);

        private IWebElement DemoTestingSiteMenuItem => Browser.Driver.FindElement(DemoTestingSiteMenuItemLocator);

        private IWebElement ProgressBarMenuItem =>  Browser.Driver.FindElement(ProgressBarMenuItemLocator);

        public ProgressBarDownLoadPage NavigateToProgressBarPage ()
        {
            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(TesterOptions);
            action.MoveToElement(DemoTestingSiteMenuItem);
            action.MoveToElement(ProgressBarMenuItem).Click();
            action.Build().Perform();
            return CreatePageInstance<ProgressBarDownLoadPage>();
        }

    }
}
