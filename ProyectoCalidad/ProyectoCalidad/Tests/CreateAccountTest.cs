using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Tests
{
    class CreateAccountTest
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
        public void createAccout()
        {
            CreateAccountPage productPage = new CreateAccountPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            productPage.createAccount("julianStartupsafe@gmail.com","Julian", "Herrera","Gatos123!");
            //Assert.True(this.driver.Title.Contains("Cart : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
