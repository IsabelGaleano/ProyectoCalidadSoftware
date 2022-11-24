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
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);

            
        }

        [Test]
        public void login()
        {
            LoginPage productPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            productPage.login("julianStartupsafe@gmail.com",  "Gatos123!");
            //Assert.True(this.driver.Title.Contains("Cart : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
