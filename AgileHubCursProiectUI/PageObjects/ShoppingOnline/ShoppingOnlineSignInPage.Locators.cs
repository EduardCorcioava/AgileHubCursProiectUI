using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineSignInPage
    {
        private IWebDriver _driver;
        public ShoppingOnlineSignInPage(IWebDriver driver) => _driver = driver;

        private IWebElement CreateAccountButton => _driver.FindElement(By.XPath("//div[@class='submit']//button[@name='SubmitCreate']"));
        private IWebElement EmailField => _driver.FindElement(By.XPath("//input[@name='email_create']"));

        private IWebElement PersonalInformationTitleRadioButton => _driver.FindElement(By.XPath("//input[@id='id_gender1']"));
        private IWebElement PersonalInformationFirstNameField => _driver.FindElement(By.XPath("//input[@name='customer_firstname']"));
        private IWebElement PersonalInformationLastNameField => _driver.FindElement(By.XPath("//input[@name='customer_lastname']"));
        private IWebElement PersonalInformationPasswordField => _driver.FindElement(By.XPath("//input[@name='passwd']"));
        private IWebElement SelectDayBox => _driver.FindElement(By.XPath("//div[@id='uniform-days']"));
        private IWebElement SelectDay => _driver.FindElement(By.XPath("//select[@id='days']//option[@value='15']"));
        private IWebElement SelectMonthBox => _driver.FindElement(By.XPath("//div[@id='uniform-months']"));
        private IWebElement SelectMonth => _driver.FindElement(By.XPath("//select[@id='months']//option[@value='5']"));
        private IWebElement SelectYearsBox => _driver.FindElement(By.XPath("//div[@id='uniform-years']"));
        private IWebElement SelectYear => _driver.FindElement(By.XPath("//select[@id='years']//option[@value='2000']"));
        private IWebElement AdressAddressField => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//input[@name='address1']"));
        private IWebElement AdressCityField => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//input[@name='city']"));
        private IWebElement AdressStateDropdown => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//select[@name='id_state']"));
        private IWebElement AdressState => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//select[@name='id_state']//option[@value='4']"));
        private IWebElement AdressPostcodeField => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//input[@name='postcode']"));
        private IWebElement AdressMobilePhoneField => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//input[@name='phone_mobile']"));
        private IWebElement AdressAliasField => _driver.FindElement(By.XPath("//div[@class='account_creation'][2]//input[@name='alias']"));
        private IWebElement RegisterButton => _driver.FindElement(By.XPath("//button[@name='submitAccount']//span[contains(text(),'Register')]"));

        private IWebElement AddressesText => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));
    }
}
