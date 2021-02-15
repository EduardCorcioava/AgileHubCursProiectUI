using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineOtherPages
    {
        private IWebDriver _driver;
        public ShoppingOnlineOtherPages(IWebDriver driver) => _driver = driver;

        private IWebElement FirstBlouse => _driver.FindElement(By.XPath("//div[@class='product-image-container']//img[@class='replace-2x img-responsive']"));
        private IWebElement FirstBlouseBigImage => _driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[1]/span/img"));
        private IWebElement AddToCartButton => _driver.FindElement(By.XPath("//button[@type='submit']//span[contains(text(),'Add to cart')]"));
        private IWebElement ContinueShoppingButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span"));

        private IWebElement DressesTab => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[2]/a"));
        private IWebElement SummerDressesSubMenu => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[2]/ul/li[3]/a"));
        private IWebElement ThirdDress => _driver.FindElement(By.XPath("//div[@class='product-image-container']//img[@title='Printed Chiffon Dress']"));
        private IWebElement ThirdDressBigImage => _driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[1]/span[2]/img"));

        private IWebElement TshirtsTab => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a")); 
        private IWebElement FirstTshirt => _driver.FindElement(By.XPath("//div[@class='product-image-container']//img[@title='Faded Short Sleeve T-shirts']"));
        private IWebElement FirstTshirtBigImage => _driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[1]/span/img"));
        private IWebElement CheckoutButton => _driver.FindElement(By.XPath("//div[@class='button-container']//a[@title='Proceed to checkout']"));
        private IWebElement CartButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[3]/div/a"));

        private IWebElement ShoppingCartSummaryText => _driver.FindElement(By.XPath("//h1[contains(text(),'Shopping-cart summary')]"));
        private IWebElement ProceedCheckoutButton => _driver.FindElement(By.XPath("//p[@class='cart_navigation clearfix']//span[contains(text(),'Proceed to checkout')]")); 

        private IWebElement AuthenticationText => _driver.FindElement(By.XPath("//h1[contains(text(),'Authentication')]"));


    }
}
