using OpenQA.Selenium;
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
            btnaddToCart.Click();
            Thread.Sleep(5000);



        }
    }
}
