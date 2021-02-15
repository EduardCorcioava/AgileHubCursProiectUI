using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelLocationPage
    {
        public void ValidateLocationSelect()
        {
            Helper.ScrollToSeeTheRightButton(_driver, RendezvousHotel);
            RendezvousHotel.Click();

            Helper.ScrollToSeeTheRightButton(_driver, TypeOfRoom);
            SelectRoomCheckbox.Click();
            Helper.ScrollToSeeTheRightButton(_driver, OneBedroomText);
            BookButton.Click();
        }

        public bool VerifyBookingPageDisplayed()
        {
            return BookAsAGuestText.Displayed;
        }
        
    }
}
