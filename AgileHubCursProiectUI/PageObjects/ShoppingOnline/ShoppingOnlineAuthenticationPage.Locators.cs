using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineAuthenticationPage
    {
        private IWebDriver _driver;
        public ShoppingOnlineAuthenticationPage(IWebDriver driver) => _driver = driver;

        private IWebElement SignInButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));

        //private IWebElement AuthenticationText => _driver.FindElement(By.XPath("//h1[contains(text(),'Authentication')]"));
        private IWebElement EmailAddressField => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/form/div/div[1]/input"));
        private IWebElement PasswordField => _driver.FindElement(By.XPath("//input[@type='password']"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/form/div/p[2]/button/span"));

        private IWebElement MyAccountText => _driver.FindElement(By.XPath("//h1[contains(text(),'My account')]"));

        
    }
}
