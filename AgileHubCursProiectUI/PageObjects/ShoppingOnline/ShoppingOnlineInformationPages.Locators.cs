using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineInformationPages
    {
        private IWebDriver _driver;
        public ShoppingOnlineInformationPages(IWebDriver driver) => _driver = driver;


        
        private IWebElement PersonalInformationTab => _driver.FindElement(By.XPath("//span[contains(text(),'My personal information')]"));

       private IWebElement YourPersonalInformationText => _driver.FindElement(By.XPath("//h1[contains(text(),' Your personal information')]"));
        private IWebElement OldPasswordField => _driver.FindElement(By.XPath("//input[@id='old_passwd']"));
        private IWebElement NewPasswordField => _driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement ConfirmPasswordField => _driver.FindElement(By.XPath("//input[@id='confirmation']"));
        private IWebElement SaveButton => _driver.FindElement(By.XPath("//span[contains(text(),'Save')]"));

        private IWebElement InformationSuccessfullyUpdatedText => _driver.FindElement(By.XPath("//h1[contains(text(),' Your personal information')]"));

    }
}
