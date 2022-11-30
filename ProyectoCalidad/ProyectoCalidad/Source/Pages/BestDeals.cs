using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    internal class BestDeals
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "a[data-track='[context:widgetType=polaroid,linkContent=global_GL-76777_HOLFY23_DOTD_COPE_10242022,linkRegion=Global Polaroids,linkPlacement=c1w1]']")]
        private IWebElement dealOfTheDay;

        public BestDeals(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToTopDealsGames()
        {
            dealOfTheDay.Click();
            Thread.Sleep(1000);
        }
    }
}
