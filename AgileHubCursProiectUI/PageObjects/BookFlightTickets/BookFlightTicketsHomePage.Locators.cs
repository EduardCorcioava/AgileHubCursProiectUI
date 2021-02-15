using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsHomePage
    {
        private IWebDriver _driver;
        public BookFlightTicketsHomePage(IWebDriver driver) => _driver = driver;

        private IWebElement DepartureStationField => _driver.FindElement(By.XPath("//input[@id='search-departure-station']"));
        private IWebElement DepartureStationMark => _driver.FindElement(By.XPath("//strong[@class='locations-container__location__name']"));
        private IWebElement ArrivalStationField => _driver.FindElement(By.XPath("//input[@id='search-arrival-station']"));
        private IWebElement ArrivalStationMark => _driver.FindElement(By.XPath("//strong[@class='locations-container__location__name']"));
        private IWebElement DepartureDateField => _driver.FindElement(By.XPath("//span[@id='search-departure-date']"));
        private IWebElement NextMonthButton => _driver.FindElement(By.XPath("//button[@class='pika-next']"));
        private IWebElement DayOfDepartureButton => _driver.FindElement(By.XPath("//button[@data-pika-month='1' and @data-pika-day='13']"));
        private IWebElement DayOfReturnButton => _driver.FindElement(By.XPath("//button[@data-pika-month='1' and @data-pika-day='20']"));
        private IWebElement ConfirmDaysButton => _driver.FindElement(By.XPath("//button[@data-test='calendar-shrinkable-ok-button']"));
        private IWebElement SearchPassengerField => _driver.FindElement(By.XPath("//div[@id='search-passenger']"));
        private IWebElement AdultPassengerPlusButton => _driver.FindElement(By.XPath("(//button[@data-test='services-flight-search-increment'])[1]"));
        private IWebElement ChildPassengerPlusButton => _driver.FindElement(By.XPath("(//button[@data-test='services-flight-search-increment'])[2]"));
        private IWebElement ConfirmPassengersButton => _driver.FindElement(By.XPath("(//button[@class='base-button base-button--medium base-button--primary'])[1]"));
        private IWebElement SearchButton => _driver.FindElement(By.XPath("//button[@class='flight-search__panel__cta-btn base-button base-button--medium base-button--primary']"));

        //public IWebElement SelectFlightsTab => _driver.FindElement(By.XPath("//h2[@class='booking-flow__step__title heading heading--1']"));
    }
}
