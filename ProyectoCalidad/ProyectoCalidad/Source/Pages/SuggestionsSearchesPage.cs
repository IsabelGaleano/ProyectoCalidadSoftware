using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Source.Pages
{
    public class SuggestionsSearchesPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='typeahead']/li[1]/div/a")]
        private IWebElement linkSuggestion;

        public SuggestionsSearchesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void validateSuggestion(string searchtext)
        {
            HomePage hp = new HomePage(driver);
            hp.search(searchtext);
            string text = linkSuggestion.Text;

            if (text.Contains(searchtext))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
