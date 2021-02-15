using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineHomePage
    {
        private IWebDriver _driver;
        public ShoppingOnlineHomePage(IWebDriver driver) => _driver = driver;


        private IWebElement WomenTab => _driver.FindElement(By.XPath("//a[contains(text(),'Women')]"));
        private IWebElement BlousesSubMenu => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[1]/ul/li[1]/ul/li[2]/a"));
        private IWebElement BlousesText => _driver.FindElement(By.XPath("//div[@class='content_scene_cat_bg']//span[contains(text(),'Blouses')]"));
       
    }
}
