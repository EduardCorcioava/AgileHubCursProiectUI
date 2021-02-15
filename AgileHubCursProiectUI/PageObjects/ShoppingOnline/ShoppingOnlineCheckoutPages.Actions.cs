using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineCheckoutPages
    {
        public void ValidateAddresses()
        {
            CheckoutAddressButton.Click();
        }

        public bool VerifyShippingDisplayed()
        {
            return ShippingText.Displayed;
        }

        public void ValidateShipping()
        {
            Helper.ScrollToSeeTheRightButton(_driver, TermsOfServiceChechBox);
            TermsOfServiceChechBox.Click();
            Helper.ScrollToSeeTheRightButton(_driver, CheckoutShippingChechBox);
            CheckoutShippingChechBox.Click();
        }
        public bool VerifyPaymentDisplayed()
        {
            return PaymentText.Displayed;
        }

        public void ValidatePayment()
        {
            Helper.ScrollToSeeTheRightButton(_driver, OrderPaymentOption);
            OrderPaymentOption.Click();
        }

        public bool VerifyOrderSummaryDisplayed()
        {
            return OrderSummaryText.Displayed;
        }

        public void ValidateOrder()
        {
            Helper.ScrollToSeeTheRightButton(_driver, ConfirmOrderButton);
            ConfirmOrderButton.Click();
        }
        public bool VerifyOrderConfirmationDisplayed()
        {
            return OrderConfirmationText.Displayed;
        }
    }
}
