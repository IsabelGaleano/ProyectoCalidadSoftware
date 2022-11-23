using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
   public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "styles__SearchInput-sc-srf2ow-6")]
        private IWebElement searchtxtbox;

        [FindsBy(How = How.ClassName, Using = "styles__SearchButton-sc-srf2ow-7")]
        private IWebElement searchBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='pageBodyContainer']/div[1]/div/div[4]/div/div/div[2]/div/div[1]/div/div[2]/div/div[1]/button")]
        private IWebElement btnCategory;

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement categorieHome;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void search(string searchtext)
        {
            searchtxtbox.SendKeys(searchtext);
            searchBtn.Click();
        }

        public void findCategories()
        {

            search("peck Apple iPhone 14 Pro Presidio Perfect Clear Case");
            Thread.Sleep(2000);
            btnCategory.Click();
            Thread.Sleep(2000);
            IList<IWebElement> elements = driver.FindElements(By.ClassName("bcezkS"));
            Thread.Sleep(2000);
            IWebElement el = elements[3];
            el.Click();
            Thread.Sleep(4000);
        }


    }
}
