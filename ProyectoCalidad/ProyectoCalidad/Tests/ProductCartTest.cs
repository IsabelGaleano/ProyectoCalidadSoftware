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
    public class ProductCartTest
    {
        private IWebDriver driver;

        [SetUp]
        public void initScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void addProductCart()
        {
            ProductCartPage productPage = new ProductCartPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            productPage.addToCart();
            Assert.True(this.driver.Title.Contains("Boardwalk Brown Paper Towels - 6 Rolls : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
