using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void validateSuggestions()
        {
            SuggestionsSearchesPage page = new SuggestionsSearchesPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            page.validateSuggestion("shoes rack bench");
            Thread.Sleep(3000);
            Assert.True(this.driver.Title.Contains("Shoes Rack Bench : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
