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
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void addProductCart()
        {
            ProductCartPage productPage = new ProductCartPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.addToCart();
            Assert.True(this.driver.Title.Contains("Cart - Best Buy"));
        }

        [Test]
        public void addProductCartAgain()
        {
            ProductCartPage productPage = new ProductCartPage(driver);
            driver.Navigate().GoToUrl("https://www.bestbuy.com/?intl=nosplash");
            productPage.addToCartAgain();
            Assert.True(this.driver.Title.Contains("Cart - Best Buy"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
