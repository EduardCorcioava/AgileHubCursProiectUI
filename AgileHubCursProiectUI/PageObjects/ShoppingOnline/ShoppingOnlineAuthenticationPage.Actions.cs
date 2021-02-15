using AgileHubCursProiectUI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineAuthenticationPage
    {
        public bool VerifySignInDisplayed()
        {
            return SignInButton.Displayed;
        }
        public void ValidateAuthentication(UserDto user)
        {
            SignInButton.Click();
            Helper.ScrollToSeeTheRightButton(_driver, EmailAddressField);
            EmailAddressField.Click();
            var emailAddressValue = user.GetType().GetRuntimeProperty("emailAddress").GetValue(user);
            if (emailAddressValue != null)
            {
                EmailAddressField.SendKeys(emailAddressValue.ToString());
            }
            PasswordField.Click();
            var passwordValue = user.GetType().GetRuntimeProperty("password").GetValue(user);
            if (passwordValue != null)
            {
                PasswordField.SendKeys(passwordValue.ToString());
            }
            SubmitButton.Click();
        }

        public bool VerifyMyAccountTextDisplayed()
        {
            return MyAccountText.Displayed;
        }
    }
}
