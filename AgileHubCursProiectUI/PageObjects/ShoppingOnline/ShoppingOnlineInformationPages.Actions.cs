using AgileHubCursProiectUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineInformationPages
    {
        public bool VerifyMyAccountTextDisplayed()
        {
            return YourPersonalInformationText.Displayed;
        }
        public void ValidateAccesInformationPage()
        {
            PersonalInformationTab.Click();
        }

        public bool VerifyYourPersonalInformationTextDisplayed()
        {
            return YourPersonalInformationText.Displayed;
        }

        public void ValidateNewInformation(UserDto user)
        {
            Helper.ScrollToSeeTheRightButton(_driver, SaveButton);
            OldPasswordField.Click();
            var oldPasswordValue = user.GetType().GetRuntimeProperty("password").GetValue(user);
            if (oldPasswordValue != null)
            {
                OldPasswordField.SendKeys(oldPasswordValue.ToString());
            }
            NewPasswordField.Click();
            var newPasswordValue = user.GetType().GetRuntimeProperty("newPassword").GetValue(user);
            if (newPasswordValue != null)
            {
                NewPasswordField.SendKeys(newPasswordValue.ToString());
            }
            ConfirmPasswordField.Click();
            var confirmPasswordValue = user.GetType().GetRuntimeProperty("newPassword").GetValue(user);
            if (confirmPasswordValue != null)
            {
                ConfirmPasswordField.SendKeys(confirmPasswordValue.ToString());
            }
            SaveButton.Click();
        }
      
        public bool VerifySavedInformationDisplayed()
        {
            return InformationSuccessfullyUpdatedText.Displayed;
        }
    }
}
