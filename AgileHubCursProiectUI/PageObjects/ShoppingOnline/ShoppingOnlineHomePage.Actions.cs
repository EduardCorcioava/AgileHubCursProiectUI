using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace AgileHubCursProiectUI.PageObjects
{
    partial class ShoppingOnlineHomePage
    {
        public void ValidateSelectionClothes()
        {
            Actions actions = new Actions(_driver);
            IWebElement target = WomenTab;
            actions.MoveToElement(target).Perform();
            BlousesSubMenu.Click();
        }

        public bool VerifyBlousesDisplayed()
        {
            return BlousesText.Displayed;
        }
    }
}
