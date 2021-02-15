using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AgileHubCursProiectUI.PageObjects;
using System.Threading;

namespace AgileHubCursProiectUI.Steps
{
    [Binding]
    public sealed class BookFlightTicketsSteps : BaseDriver
    {
        //private IWebDriver _driver;

        //public BookFlightTicketsSteps(IWebDriver driver) => _driver = driver;



        [Given(@"I go to the '(.*)' website and choose the tickets data")]
        public void GivenIGoToTheWebsiteAndChooseTheTicketsData(string pageUrl)
        {
            BasePage basePage = new BasePage(Driver);
            BookFlightTicketsHomePage bookFlightTicketsHomePage = new BookFlightTicketsHomePage(Driver);

            basePage.NavigateToUrl("https://wizzair.com/ro-ro/");
            Thread.Sleep(40000);
            bookFlightTicketsHomePage.EnterTicketsData();
            Thread.Sleep(60000);
            
        }

        [When(@"I select the flights")]
        public void WhenISelectTheFlights()
        {
            BookFlightTicketsSelectPage bookFlightTicketsSelectPage = new BookFlightTicketsSelectPage(Driver);
            
            //Assert.IsTrue(bookFlightTicketsSelectPage.IsFirstFlightPriceDisplayed());
            bookFlightTicketsSelectPage.SelectFlights();
        }

        [Then(@"I can see the total price")]
        public void ThenICanSeeTheTotalPrice()
        {
            BookFlightTicketsSelectPage bookFlightTicketsSelectPage = new BookFlightTicketsSelectPage(Driver);
            Assert.IsTrue(bookFlightTicketsSelectPage.IsTotalPriceDisplayed());
        }


    }
}
