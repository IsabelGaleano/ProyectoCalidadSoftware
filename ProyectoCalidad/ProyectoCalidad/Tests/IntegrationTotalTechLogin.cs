﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProyectoCalidad.Source.Pages;

namespace ProyectoCalidad.Tests
{
    internal class IntegrationTotalTechLogin
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
        public void validateRedirect()
        {
            LoginPage productPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.login("julianStartupsafe@gmail.com", "GatosLuw123!");
            TotalTech totalTech = new TotalTech(driver);
            totalTech.goToTotalTech();
            Assert.True(this.driver.Url.Equals("https://www.bestbuy.com/site/electronics/totaltech/pcmcat1629315977983.c?id=pcmcat1629315977983"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
