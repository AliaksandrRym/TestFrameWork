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
            var progressBarPage = OpenHomePage().NavigateToProgressBarPage();
            progressBarPage.ClickDownloadButton();
            var loadingCompleteTextAppeared = progressBarPage.LoadingCompleteTextAppeared("Complete!");
            var progressBarCurrentValue = progressBarPage.GetProgressBarCurrentValue();

            Assert.IsTrue(loadingCompleteTextAppeared, "Text 'Complete' did not appear");
            Assert.AreEqual("100", progressBarCurrentValue,  "Progress bar value is not 100");
        }
    }
}
