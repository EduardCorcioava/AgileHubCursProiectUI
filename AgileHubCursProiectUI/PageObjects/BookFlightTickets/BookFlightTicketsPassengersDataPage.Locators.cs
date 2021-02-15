using OpenQA.Selenium;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsPassengersDataPage
    {
        private IWebDriver _driver;
        public BookFlightTicketsPassengersDataPage(IWebDriver driver) => _driver = driver;
        private IWebElement FirstNameOfFirstPassengerField => _driver.FindElement(By.XPath("//button[@id='passengers-continue-btn']"));
        private IWebElement LastNameOfFirstPassengerField => _driver.FindElement(By.XPath("//input[@id='passenger-last-name-0']"));
        private IWebElement SelectFirstPassengerGenderButton => _driver.FindElement(By.XPath("(//span[contains(text(),'Masculin')])[1]"));
        private IWebElement FirstContinueButton => _driver.FindElement(By.XPath("//button[contains(text(),'continuare')]"));

        private IWebElement FirstNameOfSecondPassengerField => _driver.FindElement(By.XPath("//input[@id='passenger-first-name-1']"));
        private IWebElement LastNameOfSecondPassengerField => _driver.FindElement(By.XPath("//input[@id='passenger-last-name-1']"));
        private IWebElement SelectSecondPassengerGenderButton => _driver.FindElement(By.XPath("(//span[contains(text(),'Feminin')])[1]"));
        private IWebElement SecondContinueButton => _driver.FindElement(By.XPath("(//button[contains(text(),'continuare')])[2]"));

        private IWebElement FirstNameOfThirdPassengerField => _driver.FindElement(By.XPath("//input[@id='passenger-first-name-2']"));
        private IWebElement LastNameOfThirdPassengerField => _driver.FindElement(By.XPath("//input[@id='passenger-last-name-2']"));
        private IWebElement SelectThirdPassengerGenderButton => _driver.FindElement(By.XPath("(//span[contains(text(),'Masculin')])[3]"));
        private IWebElement DateOfBirthField => _driver.FindElement(By.XPath("//input[@id='dateOfBirth-2']"));
        private IWebElement SelectYearDropdown => _driver.FindElement(By.XPath("//select[@class='pika-select pika-select-year']"));
        private IWebElement ChooseYear => _driver.FindElement(By.XPath("//option[@value='2008']"));
        private IWebElement ChooseDay => _driver.FindElement(By.XPath("//button[@data-pika-month='1' and @data-pika-day='22']"));
        private IWebElement OKButton => _driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));

        private IWebElement ContinueWithSeatsButton => _driver.FindElement(By.XPath("//button[@id='passengers-continue-btn']"));

        
        public IWebElement LoginPopup => _driver.FindElement(By.XPath("//h2[contains(text(),'Conectați-vă')]"));


    }
}
