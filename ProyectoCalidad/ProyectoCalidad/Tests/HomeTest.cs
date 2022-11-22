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
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void searchShoes()
        {
            HomePage homePage = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            homePage.search("shoes racks");
            Console.WriteLine(driver.Title);
            Assert.True(this.driver.Title.Contains("Target : Expect More. Pay Less."));

        }


        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
