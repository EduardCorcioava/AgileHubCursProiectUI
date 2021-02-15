using AgileHubCursProiectUI.Dto;
using AgileHubCursProiectUI.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AgileHubCursProiectUI.Steps
{
    [Binding]
    public sealed class ShoppingOnlineSteps:BaseDriver
    {
        [Given(@"I go to an e-commerce website")]
        public void GivenIGoToAnE_CommerceWebsite()
        {
            BasePage basePage = new BasePage(Driver);
            ShoppingOnlineHomePage shoppingOnlineHomePage = new ShoppingOnlineHomePage(Driver);
            basePage.NavigateToUrl("http://automationpractice.com/index.php");
            shoppingOnlineHomePage.ValidateSelectionClothes();
            Assert.IsTrue(shoppingOnlineHomePage.VerifyBlousesDisplayed());
        }

        [Given(@"I choose what I want to buy")]
        public void GivenIChooseWhatIWantToBuy()
        {
            ShoppingOnlineOtherPages shoppingOnlineOtherPages = new ShoppingOnlineOtherPages(Driver);
            shoppingOnlineOtherPages.ValidateProductsChosen();
            Assert.IsTrue(shoppingOnlineOtherPages.VerifyShoppingCartDisplayed());
            shoppingOnlineOtherPages.ValidateOrder();
            Assert.IsTrue(shoppingOnlineOtherPages.VerifyCreateAccountDisplayed());          
        }


        [When(@"I'm creating an account")]
        public void WhenIMCreatingAnAccount(Table table)
        {
            var myCredentials = table.CreateInstance<UserDto>();
            ShoppingOnlineSignInPage shoppingOnlineSignInPage = new ShoppingOnlineSignInPage(Driver);
            shoppingOnlineSignInPage.ValidateSignIn(myCredentials);
            Assert.IsTrue(shoppingOnlineSignInPage.VerifyAddressesDisplayed()); 
            
        }

        [Then(@"my order is processed successfully")]
        public void ThenMyOrderIsProcessedSuccessfully()
        {
            ShoppingOnlineCheckoutPages shoppingOnlineCheckoutPages = new ShoppingOnlineCheckoutPages(Driver);
            shoppingOnlineCheckoutPages.ValidateAddresses();
            Assert.IsTrue(shoppingOnlineCheckoutPages.VerifyShippingDisplayed());
            shoppingOnlineCheckoutPages.ValidateShipping();
            Assert.IsTrue(shoppingOnlineCheckoutPages.VerifyPaymentDisplayed());
            shoppingOnlineCheckoutPages.ValidatePayment();
            Assert.IsTrue(shoppingOnlineCheckoutPages.VerifyOrderSummaryDisplayed());
            shoppingOnlineCheckoutPages.ValidateOrder();
            Assert.IsTrue(shoppingOnlineCheckoutPages.VerifyOrderConfirmationDisplayed());
        }

        [Given(@"I login with my credentials")]
        public void GivenILoginWithMyCredentials(Table table)
        {
            BasePage basePage = new BasePage(Driver);
            var myLoginData = table.CreateInstance<UserDto>();
            ShoppingOnlineAuthenticationPage shoppingOnlineAuthenticationPage = new ShoppingOnlineAuthenticationPage(Driver);
            basePage.NavigateToUrl("http://automationpractice.com/index.php");
            Assert.IsTrue(shoppingOnlineAuthenticationPage.VerifySignInDisplayed());
            shoppingOnlineAuthenticationPage.ValidateAuthentication(myLoginData);
            Assert.IsTrue(shoppingOnlineAuthenticationPage.VerifyMyAccountTextDisplayed());
        }

        [Given(@"I open may personal information page")]
        public void GivenIOpenMayPersonalInformationPage()
        {
            ShoppingOnlineInformationPages shoppingOnlineInformationPages = new ShoppingOnlineInformationPages(Driver);
            shoppingOnlineInformationPages.ValidateAccesInformationPage(); 
            Assert.IsTrue(shoppingOnlineInformationPages.VerifyYourPersonalInformationTextDisplayed());
        }

        [When(@"I enter the new information")]
        public void WhenIEnterTheNewInformation(Table table)
        {
            var myNewData = table.CreateInstance<UserDto>();
            ShoppingOnlineInformationPages shoppingOnlineInformationPages = new ShoppingOnlineInformationPages(Driver);
            shoppingOnlineInformationPages.ValidateNewInformation(myNewData);
        
        }

        [Then(@"my new data are saved successfully")]
        public void ThenMyNewDataAreSavedSuccessfully()
        {
            ShoppingOnlineInformationPages shoppingOnlineInformationPages = new ShoppingOnlineInformationPages(Driver);
            Assert.IsTrue(shoppingOnlineInformationPages.VerifySavedInformationDisplayed());
        }

    }
}
