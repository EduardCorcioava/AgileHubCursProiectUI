using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineCheckoutPages
    {
        private IWebDriver _driver;
        public ShoppingOnlineCheckoutPages(IWebDriver driver) => _driver = driver;

        private IWebElement CheckoutAddressButton => _driver.FindElement(By.XPath("//button[@name='processAddress']"));

        private IWebElement ShippingText => _driver.FindElement(By.XPath("//h1[@class='page-heading']"));
        private IWebElement TermsOfServiceChechBox => _driver.FindElement(By.XPath("//div[@class='checker']//input[@id='cgv']"));
        private IWebElement CheckoutShippingChechBox => _driver.FindElement(By.XPath("//button[@name='processCarrier']"));

        private IWebElement PaymentText => _driver.FindElement(By.XPath("//h1[contains(text(),'Please choose your payment method')]"));
        private IWebElement OrderPaymentOption => _driver.FindElement(By.XPath("//a[@title='Pay by bank wire']"));

        private IWebElement OrderSummaryText => _driver.FindElement(By.XPath("//h1[contains(text(),'Order summary')]"));
        private IWebElement ConfirmOrderButton => _driver.FindElement(By.XPath("//button[@type='submit']//span[contains(text(),'I confirm my order')]"));

        private IWebElement OrderConfirmationText => _driver.FindElement(By.XPath("//h1[contains(text(),'Order confirmation')]"));
    }
}
