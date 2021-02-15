using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects.YourStore
{
    partial class YourStoreHomePage
    {
        private IWebDriver _driver;
        public YourStoreHomePage(IWebDriver driver) => _driver = driver;

        private IWebElement MyAccountButton => _driver.FindElement(By.XPath("//span[contains(text(),'My Account')]"));
        private IWebElement RegisterButton => _driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));


        private IWebElement FirstNameField => _driver.FindElement(By.XPath("//input[@name='firstname']"));
        private IWebElement LastNameField => _driver.FindElement(By.XPath("//input[@name='lastname']"));
        private IWebElement EmailField => _driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement TelephoneField => _driver.FindElement(By.XPath("//input[@name='telephone']"));

        private IWebElement PasswordField => _driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement PasswordConfirmField => _driver.FindElement(By.XPath("//input[@name='confirm']"));
        private IWebElement AgreeTermsCheckBox => _driver.FindElement(By.XPath("//input[@name='agree']"));
        private IWebElement ContinuButton => _driver.FindElement(By.XPath("//input[@value='Continue']"));


    }
}
