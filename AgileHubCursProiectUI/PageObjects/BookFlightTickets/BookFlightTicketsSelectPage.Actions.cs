using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsSelectPage
    {
        public void SelectFlights()
        {
            Thread.Sleep(4000);
            SelectFirstFlightButton.Click();

            Helper.ScrollToSeeTheFlights(_driver, SelectPriceOfFirstFlightButton);
            SelectPriceOfFirstFlightButton.Click();

            SelectReturnFlightButton.Click();
            Helper.ScrollToSeeTheFlights(_driver, SelectPriceOfReturnFlightButton);
            SelectPriceOfReturnFlightButton.Click();

            ContinueButton.Click();

            
        }
        public bool IsFirstFlightPriceDisplayed()
        {
            return SelectFirstFlightButton.Displayed;
        }
        public bool IsTotalPriceDisplayed()
        {
            return TotalPriceField.Displayed;
        }
    }
}
