using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AgileHubCursProiectUI.PageObjects;
using System.Threading;
using System;

namespace AgileHubCursProiectUI.Steps
{
    [Binding]
    public sealed class BuyShoesSteps : BaseDriver
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public BuyShoesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I go to the '(.*)' website and select men shop")]
        public void GivenIGoToTheWebsiteAndSelectMenShop(string p0)
        {
            BasePage basePage = new BasePage(Driver);
            BuyShoesHomePage buyShoesHomePage = new BuyShoesHomePage(Driver);
            basePage.NavigateToUrl("https://adidas.com/");
            buyShoesHomePage.CookieTracking();
            Assert.IsTrue(buyShoesHomePage.IsShopMenDisplayed());
            buyShoesHomePage.SelectMenShop();

        }

        [When(@"I choose the shoes")]
        public void WhenIChooseTheShoes()
        {
            BuyShoesHomePage buyShoesHomePage = new BuyShoesHomePage(Driver);
            buyShoesHomePage.ChooseShoesCategory();
           
        }

        [Then(@"I can see them in the cart")]
        public void ThenICanSeeThemInTheCart()
        {
            BuyShoesHomePage buyShoesHomePage = new BuyShoesHomePage(Driver);
            buyShoesHomePage.AddShoesToCart();
            Thread.Sleep(2000);
            Assert.IsTrue(buyShoesHomePage.IsYourBagDisplayed());
        }

        [When(@"I select exchanges%return option")]
        public void WhenISelectExchangesReturnOption()
        {
            BuyShoesOtherPages buyShoesOtherPages = new BuyShoesOtherPages(Driver);
            buyShoesOtherPages.SelectReturnOption();
            Thread.Sleep(2000);
        }

        [When(@"I choose the return policy")]
        public void WhenIChooseTheReturnPolicy()
        {
            BuyShoesOtherPages buyShoesOtherPages = new BuyShoesOtherPages(Driver);
            buyShoesOtherPages.ChooseReturnPolicy();
            Thread.Sleep(2000);
        }

        [Then(@"I can see how can I return my product")]
        public void ThenICanSeeHowCanIReturnMyProduct()
        {
            BuyShoesOtherPages buyShoesOtherPages = new BuyShoesOtherPages(Driver);
            buyShoesOtherPages.SeeReturnPolicy();
            Thread.Sleep(2000);
            Assert.IsTrue(buyShoesOtherPages.IsCanIExchangeMyProductDisplayed());
        }



    }
}
