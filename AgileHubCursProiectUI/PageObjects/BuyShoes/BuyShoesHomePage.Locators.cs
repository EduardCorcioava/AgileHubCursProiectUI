using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BuyShoesHomePage
    {
        private IWebDriver _driver;
        public BuyShoesHomePage(IWebDriver driver) => _driver = driver;

        private IWebElement AcceptTrackingButton => _driver.FindElement(By.XPath("//button[@class='gl-cta gl-cta--primary gl-cta--full-width']"));

        private IWebElement ClosePopUp => _driver.FindElement(By.XPath("//button[@class='gl-modal__close']"));

        private IWebElement ShopMenButton => _driver.FindElement(By.XPath("//a[@href='/men']"));
        private IWebElement ShoesButton => _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[1]/div/div[3]/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div[1]/div[2]/div/a"));
        private IWebElement FirstImage => _driver.FindElement(By.XPath("//div[@class='main-container___1uD-y col-s-12 no-gutters-s col-l-24']//img[@data-auto-id='image']"));
        private IWebElement ShoeSizeButton => _driver.FindElement(By.XPath("//div[@class='size-selector___2htsB']//button[@data-di-id='size_11']"));
        private IWebElement AddToBagButton => _driver.FindElement(By.XPath("//button[@data-auto-id='add-to-bag']"));
        private IWebElement ViewBagButton => _driver.FindElement(By.XPath("//div[@class='order-summary___3sMsw gl-vspace-bpl-small']//span[contains(text(),'View Bag')]"));
        private IWebElement YourBagText => _driver.FindElement(By.XPath("//div[@class='cart-header__title-container___3at81 col-s-12 row']//h3[contains(text(),'Your Bag')]"));
    }
}
