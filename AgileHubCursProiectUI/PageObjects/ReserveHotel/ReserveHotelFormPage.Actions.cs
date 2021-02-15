using AgileHubCursProiectUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.ReserveHotel
{
    partial class ReserveHotelFormPage
    {
        public void ValidateGuestsData()
        {
            var myList = ReserveHotelDto.LoadValuesFromJsonFile();
            foreach (var firstName in myList)
            {
                 FirstNameField.Click();               
                 FirstNameField.SendKeys(firstName.ToString());

                
            }





            //FirstNameField.Click();
            //var firstNameValue = reserve.GetType().GetRuntimeProperty("FirstName").GetValue(reserve);
            //if (firstNameValue != null)
            //{
            //    FirstNameField.SendKeys(firstNameValue.ToString());
            //}
            //LastNameField.Click();
            //var lastNameValue = reserve.GetType().GetRuntimeProperty("LastName").GetValue(reserve);
            //if (lastNameValue != null)
            //{
            //    FirstNameField.SendKeys(lastNameValue.ToString());
            //}
            //EmailField.Click();
            //var emailValue = reserve.GetType().GetRuntimeProperty("Email").GetValue(reserve);
            //if (emailValue != null)
            //{
            //    FirstNameField.SendKeys(emailValue.ToString());
            //}
            //ConfirmEmailField.Click();
            //var confirmEmailValue = reserve.GetType().GetRuntimeProperty("ConfirmEmail").GetValue(reserve);
            //if (confirmEmailValue != null)
            //{
            //    FirstNameField.SendKeys(confirmEmailValue.ToString());
            //}
            //Helper.ScrollToSeeTheRightButton(_driver, ContactNumberField);
            //ContactNumberField.Click();
            //var contactNumberValue = reserve.GetType().GetRuntimeProperty("ContactNumber").GetValue(reserve);
            //if (contactNumberValue != null)
            //{
            //    FirstNameField.SendKeys(contactNumberValue.ToString());
            //}
            //AddressField.Click();
            //var AddressValue = reserve.GetType().GetRuntimeProperty("Address").GetValue(reserve);
            //if (AddressValue != null)
            //{
            //    FirstNameField.SendKeys(AddressValue.ToString());
            //}
            SelectCountryDropdown.Click();
            Chooseountry.Click();
            Helper.ScrollToSeeTheRightButton(_driver, ConfirmBookingButton);
            ConfirmBookingButton.Click();

            PayButton.Click();
        }

        public bool VerifyBookingDetailsTextDisplayed()
            {
                return BookingDetailsText.Displayed;
            }





    }
}
