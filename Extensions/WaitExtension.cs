namespace TestFrameWork.Extensions
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public static class WaitExtension
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By locator, int timeOut) =>
           new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut)).Until<IWebElement>(d => d.FindElement(locator));

        public static bool WaitElementTextEquals(this IWebDriver driver, By locator, int timeOut, string text) => 
            new WebDriverWait(driver, TimeSpan.FromSeconds((int) timeOut)).Until<bool>((Func<IWebDriver, bool>)(d => d.FindElement(locator).Text == text));

        public static bool WaitElementAttributeEquals(this IWebDriver driver, By locator, int timeOut, string attribute, string attributeValue) =>
            new WebDriverWait(driver, TimeSpan.FromSeconds((int)timeOut)).Until<bool>((Func<IWebDriver, bool>)(d => d.FindElement(locator).GetAttribute(attribute) == attributeValue));

    }
}
