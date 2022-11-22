using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ProyectoCalidad.Tests
{
    public class SuggestionsTest
    {
        private IWebDriver driver;

        [SetUp]
        public void initScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void validateSuggestions()
        {
            SuggestionsSearchesPage page = new SuggestionsSearchesPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            page.validateSuggestion("shoes");
            Assert.True(this.driver.Title.Contains("Target : Expect More. Pay Less."));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
