using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelHomePage
    {
        private IWebDriver _driver;
        public ReserveHotelHomePage(IWebDriver driver) => _driver = driver;

        private IWebElement DestinationField => _driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[3]/div/div/div/div/div/div/div[1]/div/div/form/div/div/div[1]/div/div[2]/div/a"));
        private IWebElement DestinationLocation => _driver.FindElement(By.XPath("/html/body/div[5]/ul/li[1]/ul/li[1]"));
        private IWebElement CheckinDate => _driver.FindElement(By.XPath("//div[@class='form-icon-left']//input[@id='checkin']"));
        private IWebElement NextMonthButtton => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/nav/div[3]"));
        private IWebElement CheckinDay => _driver.FindElement(By.XPath("//div[@class='datepicker--cell datepicker--cell-day -weekend-' and contains(text(),'14')]"));
        private IWebElement CheckoutDate => _driver.FindElement(By.XPath("//input[@name='checkout']"));
        private IWebElement  NextMonth=> _driver.FindElement(By.XPath("/html/body/div[4]/div[2]/nav/div[3]/svg/path"));
        private IWebElement CheckoutDay => _driver.FindElement(By.XPath("(//div[@data-month='1' and @data-date='21'])[2]"));
        private IWebElement  ChildPlusButton=> _driver.FindElement(By.XPath("//div[@class='col 01']//button[@class='btn btn-white bootstrap-touchspin-up ']"));
        private IWebElement  SearchButton=> _driver.FindElement(By.XPath("//div[@class='col-lg-2 col-sm-12 col-xs-12']//button[contains(text(),'   Search')]"));

    }
}
