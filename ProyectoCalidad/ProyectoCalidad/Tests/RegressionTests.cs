using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Tests
{
    public class RegressionTests
    {
        private IWebDriver driver;

        [SetUp]
        public void initScript()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void createAccoutReg()
        {
            CreateAccountPage productPage = new CreateAccountPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.createAccount("julianStartupsafe@gmail.com", "Julian", "Herrera", "GatosLuw123!", "50684511935");
            Assert.True(this.driver.Title.Contains("Account Home - Best Buy"));
        }

        [Test]
        public void signOutReg()
        {
            SignOutPage page = new SignOutPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            page.signOut("julianStartupsafe@gmail.com", "GatosLuw123!");
            Assert.True(this.driver.Title.Contains("Best Buy | Official Online Store | Shop Now & Save"));
        }

        [Test]
        public void findCategoriesReg()
        {
            HomePage homePage = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            homePage.findCategories();
            //Assert.True(this.driver.Title.Contains("Peck Apple Iphone 14 Pro Presidio Perfect Clear Case : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
