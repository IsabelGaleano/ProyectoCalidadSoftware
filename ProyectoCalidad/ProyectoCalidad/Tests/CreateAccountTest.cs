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
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--start-maximized");
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);

        }

        [Test]
        public void createAccout()
        {
            CreateAccountPage productPage = new CreateAccountPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.createAccount("julianStartupsafe@gmail.com","Julian", "Herrera","GatosLuw123!","50684511935");
            Assert.True(this.driver.Title.Contains("Account Home - Best Buy"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
