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

        [FindsBy(How = How.ClassName, Using = "cart-item__remove")]
        private IWebElement btnRemove;

        [FindsBy(How = How.XPath, Using = "//*[@id='cartApp']/div[2]/div[1]/div/div[2]/div[1]/section[1]/div[4]/ul/li/div/div/div[4]/button")]
        private IWebElement btnSaveRemove;


        public DeleteProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void deleteProductCart()
        {
          
            ProductCartPage productCartPage = new ProductCartPage(this.driver);
            productCartPage.addToCart();
            Thread.Sleep(1000);
            btnRemove.Click();
            Thread.Sleep(1000);
            btnSaveRemove.Click();
            Thread.Sleep(2000);

        }
    }
}
