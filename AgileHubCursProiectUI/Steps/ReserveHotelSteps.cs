using AgileHubCursProiectUI.Dto;
using AgileHubCursProiectUI.PageObjects;
using AgileHubCursProiectUI.PageObjects.ReserveHotel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AgileHubCursProiectUI.Steps
{
    [Binding]
    public sealed class ReserveHotelSteps:BaseDriver
    {
        [Given(@"I go to the travel agency website and choose the travel information")]
        public void GivenIGoToTheTravelAgencyWebsiteAndChooseTheTravelInformation()
        {
            BasePage basePage = new BasePage(Driver);
            ReserveHotelHomePage reserveHotelHomePage = new ReserveHotelHomePage(Driver);
            basePage.NavigateToUrl("https://www.phptravels.net/home");
            reserveHotelHomePage.ValidateBookingData();
        }

        [Given(@"I choose the location")]
        public void GivenIChooseTheLocation()
        {
            ReserveHotelLocationPage reserveHotelLocationPage = new ReserveHotelLocationPage(Driver);
            reserveHotelLocationPage.ValidateLocationSelect();
            Assert.IsTrue(reserveHotelLocationPage.VerifyBookingPageDisplayed());
        }

        [When(@"I book the hotel room")]
        public void WhenIBookTheHotelRoom()
        {
            //var myCredentials = ReserveHotelDto.LoadValuesFromJsonFile();
            //var myCredentials = table.CreateInstance<ReserveHotelDto>();
            ReserveHotelFormPage reserveHotelFormPage = new ReserveHotelFormPage(Driver);
            reserveHotelFormPage.ValidateGuestsData();
           
        }

        [Then(@"I can see my booking details")]
        public void ThenICanSeeMyBookingDetails()
        {
            ReserveHotelFormPage reserveHotelFormPage = new ReserveHotelFormPage(Driver);
            Assert.IsTrue(reserveHotelFormPage.VerifyBookingDetailsTextDisplayed());
        }

    }
}
