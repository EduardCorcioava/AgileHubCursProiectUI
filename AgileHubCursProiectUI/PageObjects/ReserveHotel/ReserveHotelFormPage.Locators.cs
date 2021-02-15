using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelFormPage
    {
        private IWebDriver _driver;
        public ReserveHotelFormPage(IWebDriver driver) => _driver = driver;

        private IWebElement FirstNameField => _driver.FindElement(By.XPath("//span[contains(text(),'First Name')]"));
        private IWebElement LastNameField => _driver.FindElement(By.XPath("//span[contains(text(),'Last Name')]"));
        private IWebElement EmailField => _driver.FindElement(By.XPath("///div[@class='row form-group']//span[contains(text(),'Email')]"));
        private IWebElement ConfirmEmailField => _driver.FindElement(By.XPath("//div[@class='row form-group']//span[contains(text(),'Confirm')]"));
        private IWebElement ContactNumberField => _driver.FindElement(By.XPath("//span[contains(text(),'Contact Number')]"));
        private IWebElement AddressField => _driver.FindElement(By.XPath("//span[contains(text(),'Address')]"));
        private IWebElement SelectCountryDropdown => _driver.FindElement(By.XPath("//span[contains(text(),'Select Country')]"));
        private IWebElement Chooseountry => _driver.FindElement(By.XPath("//li[contains(text(),'Argentina')]"));
        private IWebElement ConfirmBookingButton => _driver.FindElement(By.XPath("///button[contains(text(),'CONFIRM THIS BOOKING')]"));

        private IWebElement BookingDetailsText => _driver.FindElement(By.XPath("//span[contains(text(),'Booking Details')]"));
        private IWebElement PayButton => _driver.FindElement(By.XPath("//button[contains(text(),'Pay on Arrival')]"));
    }
}
