
namespace UiGlobalQAPart
{
    using OpenQA.Selenium;
    using TestFrameWork.DriverCore;
    using UiGlobalQAPart.Pages;

    public class ProgressBarDownLoadPage: BasePage
    {
        private static readonly By DownloadButtonLocator = By.Id("downloadButton");

        private IWebElement DownloadButton = Browser.Driver.FindElement(DownloadButtonLocator);
    }
}
