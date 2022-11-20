using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCalidad.Source.Pages
{
    public class ProductCartPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "addToCartButtonOrTextIdFor85566674")]
        private IWebElement btnaddToCart;

        public ProductCartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void addToCart()
        {
            HomePage hp = new HomePage(driver);
            hp.search("shoes racks");
            string element = driver.FindElement(By.XPath("//*[@id='pageBodyContainer']/div[1]/div/div[4]/div/div[1]/div[2]/div/section/div/div[3]/div/div/div[1]/div[2]/div/div/div[1]/div[1]/div[1]/a")).Text;
            
            if(element.Contains("Shoe Rack Vertical Design Wooden"))
            {
                driver.FindElement(By.XPath("//*[@id='pageBodyContainer']/div[1]/div/div[4]/div/div[1]/div[2]/div/section/div/div[3]/div/div/div[1]/div[2]/div/div/div[1]/div[1]/div[1]/a")).Click();
                btnaddToCart.Click();
            } else
            {
                Console.WriteLine("Fallo");
            }
           


        }
    }
}
