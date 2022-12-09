using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    internal class TopDeals
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "a[data-track='[context:linkRegion=CustomBanner_GL-79784,linkPlacement=Open,linkContent=Shop Now]")]
        private IWebElement dealOfTheDay;

        public TopDeals(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToTopDaySales()
        {
            dealOfTheDay.Click();
            Thread.Sleep(2000);
        }
    }
}
