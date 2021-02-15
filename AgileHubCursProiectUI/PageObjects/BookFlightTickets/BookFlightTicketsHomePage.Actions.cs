using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;
using System.Threading;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsHomePage
    {
        public void EnterTicketsData()
        {
            DepartureStationField.Click();
            DepartureStationField.SendKeys("București");
            DepartureStationMark.Click();

            ArrivalStationField.Click();
            ArrivalStationField.SendKeys("Madrid");
            ArrivalStationMark.Click();

            Thread.Sleep(15000);
            //DepartureDateField.Click();
            //NextMonthButton.Click();
            //Thread.Sleep(14000);
            DayOfDepartureButton.Click();
            Thread.Sleep(14000);
            DayOfReturnButton.Click();
            ConfirmDaysButton.Click();

            Thread.Sleep(1000);
            SearchPassengerField.Click();
            AdultPassengerPlusButton.Click();
            ChildPassengerPlusButton.Click();
            Thread.Sleep(1000);
            //ConfirmPassengersButton.Click();

            Thread.Sleep(5000);
            SearchButton.Click();
        }
       
    }
}
