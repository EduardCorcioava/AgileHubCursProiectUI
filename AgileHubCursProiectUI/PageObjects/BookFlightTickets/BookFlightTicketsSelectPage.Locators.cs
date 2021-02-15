using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsSelectPage
    {
        private IWebDriver _driver;
        public BookFlightTicketsSelectPage(IWebDriver driver) => _driver = driver;
        private IWebElement SelectFirstFlightButton => _driver.FindElement(By.XPath("(//div[@class='flight-select__flight-info__icons'])[1]"));
        private IWebElement SelectPriceOfFirstFlightButton => _driver.FindElement(By.XPath("(//div[@class='fare-type-button fare-type-button--active fare-type-button--promo-enabled'])[2]"));
        private IWebElement SelectReturnFlightButton => _driver.FindElement(By.XPath("/html/body/div[2]/div/main/div/div/div[1]/div[2]/div[1]/div[6]/div[2]/div[2]/div/div/div[2]/div[1]"));
        private IWebElement SelectPriceOfReturnFlightButton => _driver.FindElement(By.XPath("(//div[@class='fare-type-button fare-type-button--active fare-type-button--promo-enabled'])[2]"));
        private IWebElement ContinueButton => _driver.FindElement(By.XPath("//button[@id='flight-select-continue-button']"));

        
        public IWebElement TotalPriceField => _driver.FindElement(By.XPath("//div[@class='booking-flow__itinerary__total']//span[contains(text(),'Total')]"));
    }
}
