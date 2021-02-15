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
    partial class ShoppingOnlineOtherPages
    {
        public void ValidateProductsChosen()
        {
            Helper.ScrollToSeeTheRightButton(_driver, FirstBlouse);
            FirstBlouse.Click();
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//iframe[@src='http://automationpractice.com/index.php?id_product=2&controller=product&content_only=1']")));
            FirstBlouseBigImage.Click();
            Helper.ScrollToSeeTheRightButton(_driver, AddToCartButton);
            AddToCartButton.Click();
            Thread.Sleep(2000);
            ContinueShoppingButton.Click();

            Actions actions = new Actions(_driver);
            IWebElement target = DressesTab;
            actions.MoveToElement(target).Perform();
            SummerDressesSubMenu.Click();
            Helper.ScrollToSeeTheRightButton(_driver, ThirdDress);
            ThirdDress.Click();
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//iframe[@src='http://automationpractice.com/index.php?id_product=7&controller=product&content_only=1']")));
            ThirdDressBigImage.Click();
            Helper.ScrollToSeeTheRightButton(_driver, AddToCartButton);
            AddToCartButton.Click();
            Thread.Sleep(3000);
            ContinueShoppingButton.Click();

            Helper.ScrollToSeeTheRightButton(_driver, TshirtsTab);
            TshirtsTab.Click();
            Helper.ScrollToSeeTheRightButton(_driver, FirstTshirt);
            FirstTshirt.Click();
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//iframe[@src='http://automationpractice.com/index.php?id_product=1&controller=product&content_only=1']")));
            FirstTshirtBigImage.Click();
            Helper.ScrollToSeeTheRightButton(_driver, AddToCartButton);
            AddToCartButton.Click();
            Thread.Sleep(3000);
            CheckoutButton.Click();
            Helper.ScrollToSeeTheRightButton(_driver, CartButton);
            CartButton.Click();
        }
 
        public bool VerifyShoppingCartDisplayed()
        {
            return ShoppingCartSummaryText.Displayed;
        }

        public void ValidateOrder()
        {
            ProceedCheckoutButton.Click();
        }

        public bool VerifyCreateAccountDisplayed()
        {
            return AuthenticationText.Displayed;
        }
    }
}
