using AgileHubCursProiectUI.PageObjects;
using AgileHubCursProiectUI.PageObjects.YourStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AgileHubCursProiectUI.Steps
{
    [Binding]
    public sealed class YourStoreSteps:BaseDriver
    {
        [Given(@"I go to the store website and I access the registration page")]
        public void GivenIGoToTheStoreWebsiteAndIAccessTheRegistrationPage()
        {
            BasePage basePage = new BasePage(Driver);
            YourStoreHomePage yourStoreHomePage = new YourStoreHomePage(Driver);
            basePage.NavigateToUrl("http://tutorialsninja.com/demo/");
            yourStoreHomePage.ValidateAccessRegistrationPage();
            Assert.IsTrue(yourStoreHomePage.VerifyRegistrationPageDisplayed());
        }

        [When(@"filled all the data")]
        public void WhenFilledAllTheData()
        {
            YourStoreHomePage yourStoreHomePage = new YourStoreHomePage(Driver);
            yourStoreHomePage.ValidateRegistration();

        }

        [Then(@"I can see that my account was created")]
        public void ThenICanSeeThatMyAccountWasCreated()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
