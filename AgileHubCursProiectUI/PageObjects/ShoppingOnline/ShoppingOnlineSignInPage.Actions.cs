using AgileHubCursProiectUI.Dto;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineSignInPage
    {
        public void ValidateSignIn(UserDto user)
        {
            Helper.ScrollToSeeTheRightButton(_driver, CreateAccountButton);
            EmailField.Click();
            var emailAddressValue = user.GetType().GetRuntimeProperty("emailAddress").GetValue(user);
            if (emailAddressValue != null)
            {
                EmailField.SendKeys(emailAddressValue.ToString());
            }
            CreateAccountButton.Click();
            Thread.Sleep(4000);

            Helper.ScrollToSeeTheRightButton(_driver, PersonalInformationTitleRadioButton);
            PersonalInformationTitleRadioButton.Click();

            PersonalInformationFirstNameField.Click();
            var firstNameValue = user.GetType().GetRuntimeProperty("firstName").GetValue(user);
            if (firstNameValue != null)
            {
                PersonalInformationFirstNameField.SendKeys(firstNameValue.ToString());
            }

            PersonalInformationLastNameField.Click();
            var lastNameValue = user.GetType().GetRuntimeProperty("lastName").GetValue(user);
            if (lastNameValue != null)
            {
                PersonalInformationLastNameField.SendKeys(lastNameValue.ToString());
            }

            PersonalInformationPasswordField.Click();
            var passwordValue = user.GetType().GetRuntimeProperty("password").GetValue(user);
            if (passwordValue != null)
            {
                PersonalInformationPasswordField.SendKeys(passwordValue.ToString());
            }

            SelectDayBox.Click();
            SelectDay.Click();
            SelectMonthBox.Click();
            SelectMonth.Click();
            SelectYearsBox.Click();
            SelectYear.Click();

            Helper.ScrollToSeeTheRightButton(_driver, AdressAddressField);
            Thread.Sleep(1000);
            AdressAddressField.Click();
            var adressAddressField = user.GetType().GetRuntimeProperty("address").GetValue(user);
            if (adressAddressField != null)
            {
                AdressAddressField.SendKeys(adressAddressField.ToString());
            }

            Thread.Sleep(1000);
            AdressCityField.Click();
            var adressCityField = user.GetType().GetRuntimeProperty("city").GetValue(user);
            if (adressCityField != null)
            {
                AdressCityField.SendKeys(adressCityField.ToString());
            }

            Thread.Sleep(1000);
            AdressStateDropdown.Click();          
            AdressState.Click();

            Thread.Sleep(1000);
            
            AdressPostcodeField.Click();
            var adressPostcodeField = user.GetType().GetRuntimeProperty("postcode").GetValue(user);
            if (adressPostcodeField != null)
            {
                AdressPostcodeField.SendKeys(adressPostcodeField.ToString());
            }
         
            Thread.Sleep(1000);
            AdressMobilePhoneField.Click();
            var adressMobilePhoneField = user.GetType().GetRuntimeProperty("mobilePhone").GetValue(user);
            if (adressMobilePhoneField != null)
            {
                AdressMobilePhoneField.SendKeys(adressMobilePhoneField.ToString());
            }

            Thread.Sleep(1000);
            AdressAliasField.Clear();
            var adressAliasField = user.GetType().GetRuntimeProperty("alias").GetValue(user);
            if (adressAliasField != null)
            {
                AdressAliasField.SendKeys(adressAliasField.ToString());
            }

            Helper.ScrollToSeeTheRightButton(_driver, RegisterButton);
            RegisterButton.Click();
        }

        public bool VerifyAddressesDisplayed()
        {
            return AddressesText.Displayed;
        }
        
    }
}
