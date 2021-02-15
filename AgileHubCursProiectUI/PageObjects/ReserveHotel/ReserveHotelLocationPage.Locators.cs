using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelLocationPage
    {
        private IWebDriver _driver;
        public ReserveHotelLocationPage(IWebDriver driver) => _driver = driver;

        private IWebElement RendezvousHotel => _driver.FindElement(By.XPath("//a[contains(text(),'Rendezvous Hotels')]"));
        private IWebElement SelectHotelButton => _driver.FindElement(By.XPath("//a[contains(text(),'Details')]"));
        private IWebElement TypeOfRoom => _driver.FindElement(By.XPath("//span[contains(text(),'Available Rooms')]"));
        private IWebElement SelectRoomCheckbox => _driver.FindElement(By.XPath("(//label[@class='custom-control-label text-left go-left'])[1]"));
        private IWebElement OneBedroomText => _driver.FindElement(By.XPath("//a[contains(text(),'One-Bedroom Apartment')]"));
        private IWebElement BookButton => _driver.FindElement(By.XPath("//button[contains(text(),'Book Now')]"));

        private IWebElement BookAsAGuestText => _driver.FindElement(By.XPath("//span[contains(text(),'Book as a Guest')]"));
    }
}
