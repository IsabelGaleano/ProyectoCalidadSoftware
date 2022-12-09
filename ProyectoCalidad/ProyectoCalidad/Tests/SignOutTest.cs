using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Tests
{
    public class SignOutTest
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
        public void signOutF()
        {
            SignOutPage page = new SignOutPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            page.signOut("julianStartupsafe@gmail.com", "GatosLuw123!");
            Assert.True(this.driver.Title.Contains("Best Buy | Official Online Store | Shop Now & Save"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
