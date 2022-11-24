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
    public class HomeTest 

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
        public void search()
        {
            HomePage homePage = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            homePage.search("shoes");
            Assert.True(this.driver.Title.Contains("shoes - Best Buy"));

        }

        [Test]
        public void findCategories()
        {
            HomePage homePage = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            homePage.findCategories();
            Assert.True(this.driver.Title.Contains("Peck Apple Iphone 14 Pro Presidio Perfect Clear Case : Target"));
        }


        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
