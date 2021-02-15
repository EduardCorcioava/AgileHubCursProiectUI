using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelHomePage
    {
        public void ValidateBookingData()
        {
            DestinationField.Click();
            Thread.Sleep(2000);
            DestinationLocation.Click();

            Thread.Sleep(2000);
            CheckinDate.Click();
            Thread.Sleep(2000);
            //NextMonthButtton.Click();
            CheckinDay.Click();

            Thread.Sleep(2000);
            CheckoutDate.Click();
            //NextMonth.Click();
            CheckoutDay.Click();

            ChildPlusButton.Click();
            SearchButton.Click();

        }
    }
}
