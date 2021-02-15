using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    class BasePage : BaseDriver
    {
        /*public readonly string SitedUrl = "https://wizzair.com/ro-ro#/";*/
        private IWebDriver _driver;

       public BasePage(IWebDriver driver) => _driver = driver;

        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
