using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using AgileHubCursProiectUI.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace AgileHubCursProiectUI
{
    [Binding]
    public sealed class Hooks: BaseDriver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

    [BeforeScenario]
        public void BeforeScenario()
        {
            CreateDriver();
        }

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    Driver.Quit();
        //}
    }
}
