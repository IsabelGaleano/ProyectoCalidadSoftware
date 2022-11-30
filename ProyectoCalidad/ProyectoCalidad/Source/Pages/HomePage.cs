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

        [FindsBy(How = How.Id, Using = "gh-search-input")]
        private IWebElement searchtxtbox;

        [FindsBy(How = How.ClassName, Using = "header-search-button")]
        private IWebElement searchBtn;

        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_utility_more'")]
        private IWebElement btnCategory;

        [FindsBy(How = How.CssSelector, Using = "a[data-lid='hdr_hol_gift_ideas']")]
        private IWebElement linkCategoryGift;

        [FindsBy(How = How.ClassName, Using = "cn-carousel-item")]
        private IList<IWebElement> listCategories;

        [FindsBy(How = How.ClassName, Using = "se-carousel-item")]
        private IList<IWebElement> listProducts;

        [FindsBy(How = How.CssSelector, Using = "a[data-lid='hdr_td_topdeals'")]
        private IWebElement topDealsButton;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void search(string searchtext)
        {
            searchtxtbox.SendKeys(searchtext);
            searchBtn.Click();
            Thread.Sleep(3000);
        }

        public void findCategories()
        {

            btnCategory.Click();
            Thread.Sleep(1000);
            linkCategoryGift.Click();
            Thread.Sleep(1000);
            IWebElement el = listCategories[2];
            el.Click();
            Thread.Sleep(1000);
            IWebElement pr = listProducts[0];
            pr.Click();
            Thread.Sleep(2000);
        }

        public void goToTopDeals()
        {
            topDealsButton.Click();
            Thread.Sleep(2000);
        }


    }
}
