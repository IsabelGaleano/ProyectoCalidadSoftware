using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoCalidad.Source.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Tests
{
    public class LoginTest
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
        public void login()
        {
            LoginPage productPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.login("julianStartupsafe@gmail.com", "GatosLuw123!");
            
        }

        [Test]
        public void wrongLogin()
        {
            LoginPage productPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.login("julianStartupsafe@gmail.com", "Gatos!456");
            IWebElement element = this.driver.FindElement(By.CssSelector(".c-alert"));
            Assert.True(element.Displayed);
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
