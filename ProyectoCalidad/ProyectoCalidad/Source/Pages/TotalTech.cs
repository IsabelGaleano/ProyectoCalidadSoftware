using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    internal class TotalTech
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "a[data-track='[context:linkRegion=Totaltech_CBW_GL77118,linkPlacement=Open,linkContent=ShopNow]")]
        private IWebElement learnMore;

        public TotalTech(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToTotalTech()
        {
            learnMore.Click();
            Thread.Sleep(2000);
        }
    }
}
