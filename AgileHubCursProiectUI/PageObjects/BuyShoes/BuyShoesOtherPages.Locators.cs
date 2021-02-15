using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BuyShoesOtherPages
    {
        private IWebDriver _driver;
        public BuyShoesOtherPages(IWebDriver driver) => _driver = driver;


        private IWebElement ExchangesReturnButton => _driver.FindElement(By.XPath("//div[@class='inner___1T3DW']//a[@manual_cm_sp='header-_-customerinfo-_-Exchanges & Returns']"));
        private IWebElement ReturnPolicyButton => _driver.FindElement(By.XPath("//div[@class='content_item']//span[contains(text(),'Return policy')]"));
        private IWebElement ReturnQuestionyButton => _driver.FindElement(By.XPath("//div[@class='ctas___21LD4']//span[contains(text(),'Can I exchange my product(s)?')]"));
        private IWebElement ExchangeMyProductText => _driver.FindElement(By.XPath("//div[@class='col-s-12 col-l-20']//h2"));
    }
}
