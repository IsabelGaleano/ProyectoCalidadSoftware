using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    public class DeleteProductPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='__next']/div[2]/div[3]/div/div/div[1]/div[2]/div/div/div[3]/div[3]/button")]
        private IWebElement btnDeleteCart;


        public DeleteProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void deleteProductCart()
        {
          
            ProductCartPage productCartPage = new ProductCartPage(this.driver);
            productCartPage.addToCart();
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.target.com/cart");
            Thread.Sleep(4000);
            btnDeleteCart.Click();
            Thread.Sleep(4000);

        }
    }
}
