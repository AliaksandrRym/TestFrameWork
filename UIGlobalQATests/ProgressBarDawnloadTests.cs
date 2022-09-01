namespace UIGlobalQATests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UiGlobalQAPart;

    [TestClass]
    public class ProgressBarDawnloadTests: BaseTest
    {
        [TestMethod]
        public void ProgressBarTest()
        {
            var homePage = OpenHomePage();
            var progressBarPage = homePage.NavigateToProgressBarPage();
        }
    }
}
