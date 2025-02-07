﻿using OpenQA.Selenium;
using System.Threading;

namespace AgileHubCursProiectUI.PageObjects
{
    class Helper
    {
        //public static void ScrollElementIntoView(IWebDriver driver, IWebElement element)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("arguments[0].scrollIntoView();", element);
        //}

        //public static void ClickWithScroll(IWebDriver driver, IWebElement element)
        //{
        //    ScrollElementIntoView(driver, element);
        //    Thread.Sleep(500);
        //    element.Click();
        //}
        public static void ScrollToSeeTheFlights(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
        public static void ScrollToSeeTheRightButton(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
    }
}
