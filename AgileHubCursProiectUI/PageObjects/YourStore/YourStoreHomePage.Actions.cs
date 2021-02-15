using AgileHubCursProiectUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.YourStore
{
    partial class YourStoreHomePage
    {
        public void ValidateAccessRegistrationPage()
        {
            MyAccountButton.Click();
            RegisterButton.Click();
        }
        public bool VerifyRegistrationPageDisplayed()
        {
            return FirstNameField.Displayed;
        }
        public void ValidateRegistration()
        {
            var myList = YourStoreDto.LoadValuesFromJsonFile();
            foreach (var firstName in myList)
            {
                FirstNameField.Click();
                FirstNameField.SendKeys(firstName.ToString());
            }
        }
    }
}
