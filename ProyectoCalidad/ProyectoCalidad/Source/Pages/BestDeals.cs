using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    internal class BestDeals
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "a[data-track='[context:linkRegion=Custom_MMT618563,linkPlacement=open,linkContent=Shop Now]")]
        private IWebElement dealOfTheDay;

        public BestDeals(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToTopDealsGames()
        {
            dealOfTheDay.Click();
            Thread.Sleep(2000);
        }
    }
}
