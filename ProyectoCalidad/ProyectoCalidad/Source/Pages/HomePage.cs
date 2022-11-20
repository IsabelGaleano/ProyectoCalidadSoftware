using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Source.Pages
{
   public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "styles__SearchInput-sc-srf2ow-6")]
        private IWebElement searchtxtbox;

        [FindsBy(How = How.ClassName, Using = "styles__SearchButton-sc-srf2ow-7")]
        private IWebElement searchBtn;


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

        
    }
}
