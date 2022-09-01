
namespace UiGlobalQAPart
{
    using OpenQA.Selenium;
    using TestFrameWork.DriverCore;
    using UiGlobalQAPart.Pages;
    using TestFrameWork.Extensions;

    public class ProgressBarDownLoadPage: BasePage
    {
        private static readonly By DownloadButtonLocator = By.XPath("//button[@id = 'downloadButton']");

        private static readonly By DialogProgressTextLocator = By.XPath("//*[@id = 'dialog']/div");

        private static readonly By IframeLocator = By.XPath("//iframe[@class = 'demo-frame lazyloaded']");

        private static readonly By ProgressBarLocator = By.Id("progressbar");


        private IWebElement IframeConteiner => Browser.Driver.FindElement(IframeLocator);
        private IWebElement DownLoadButton => Browser.Driver.FindElement(DownloadButtonLocator);


        public void ClickDownloadButton()
        {
            Browser.Driver.SwitchTo().Frame(IframeConteiner).WaitForElementDisplayed(DownloadButtonLocator, 15);
            DownLoadButton.Click();
        }

        public bool LoadingCompleteTextAppeared(string text) => Browser.Driver.WaitElementTextEquals(DialogProgressTextLocator, 30, text);

        public string GetProgressBarCurrentValue() => Browser.Driver.FindElement(ProgressBarLocator).GetAttribute("aria-valuenow");
    }
}
