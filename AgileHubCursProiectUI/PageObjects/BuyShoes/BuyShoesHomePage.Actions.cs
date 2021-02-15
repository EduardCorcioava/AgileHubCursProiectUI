using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BuyShoesHomePage
    {
        public void CookieTracking()
        {
            AcceptTrackingButton.Click();
        }
        public void SelectMenShop()
        {           
            ShopMenButton.Click();   
            Thread.Sleep(8000);
            ClosePopUp.Click();
        }
        public void ChooseShoesCategory()
        {
            Actions actions = new Actions(_driver);
            IWebElement target = ShopMenButton;
            actions.MoveToElement(target).Perform();
            Thread.Sleep(3000);
            ShoesButton.Click();
            Thread.Sleep(4000);
            FirstImage.Click();
            Thread.Sleep(3000);
            ShoeSizeButton.Click();
            Thread.Sleep(2000);
            AddToBagButton.Click();
            Thread.Sleep(3000);
        }
        public void AddShoesToCart()
        {
            ViewBagButton.Click();
        }
        public bool IsShopMenDisplayed()
        {
            return ShopMenButton.Displayed;
        }
        public bool IsYourBagDisplayed()
        {
            return YourBagText.Displayed;
        }

    }
}
