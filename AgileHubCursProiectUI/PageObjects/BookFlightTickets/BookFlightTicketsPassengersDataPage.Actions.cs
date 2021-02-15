using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BookFlightTicketsPassengersDataPage
    {
        public void ValidatePassengersData()
        {
            FirstNameOfFirstPassengerField.Click();
            FirstNameOfFirstPassengerField.SendKeys("Ion");
            LastNameOfFirstPassengerField.Click();
            LastNameOfFirstPassengerField.SendKeys("Ut");
            SelectFirstPassengerGenderButton.Click();
            Helper.ScrollToSeeTheFlights(_driver, FirstContinueButton);
            FirstContinueButton.Click();

            FirstNameOfSecondPassengerField.Click();
            FirstNameOfSecondPassengerField.SendKeys("Ele");
            LastNameOfSecondPassengerField.Click();
            LastNameOfSecondPassengerField.SendKeys("Na");
            SelectSecondPassengerGenderButton.Click();
            Helper.ScrollToSeeTheFlights(_driver, SecondContinueButton);
            SecondContinueButton.Click();

            FirstNameOfThirdPassengerField.Click();
            FirstNameOfThirdPassengerField.SendKeys("Lu");
            LastNameOfThirdPassengerField.Click();
            LastNameOfThirdPassengerField.SendKeys("Ca");
            SelectThirdPassengerGenderButton.Click();
            DateOfBirthField.Click();
            SelectYearDropdown.Click();
            ChooseYear.Click();
            ChooseDay.Click();
            Helper.ScrollToSeeTheFlights(_driver, OKButton);
            OKButton.Click();

            ContinueWithSeatsButton.Click();
        }
        
    }
}
