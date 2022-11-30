using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    public class ProductCartPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "button[data-sku-id='6497920']")]
        private IWebElement btnaddToCart;

        public ProductCartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void addToCart()
        {
            HomePage hp = new HomePage(driver);
            hp.search("shoes rack");
            Thread.Sleep(1000);
            btnaddToCart.Click();
            Thread.Sleep(5000);

        }

        public void addToCartAgain()
        {
            HomePage hp = new HomePage(driver);
            hp.search("shoes rack");
            Thread.Sleep(1000);
            btnaddToCart.Click();
            Thread.Sleep(8000);
            hp.search("shoes rack");
            Thread.Sleep(2000);
            btnaddToCart.Click();
            Thread.Sleep(5000);
        }
    }
}
