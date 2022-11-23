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
    public  class DeleteProductTest
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
            DeleteProductPage productPage = new DeleteProductPage(driver);
            driver.Navigate().GoToUrl("https://www.target.com/");
            productPage.deleteProductCart();
            Assert.True(this.driver.Title.Contains("Cart : Target"));
        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
