using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;


        [FindsBy(How = How.XPath, Using = "//*[@id='headerPrimary']/a[4]")]
        private IWebElement linkSignIn;

        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_signin']")]
        private IWebElement linkLogin;

        [FindsBy(How = How.ClassName, Using = "sign-in-btn")]
        private IWebElement elements;

        [FindsBy(How = How.Id, Using = "fld-e")]
        private IWebElement emailB;

        [FindsBy(How = How.Id, Using = "fld-p1")]
        private IWebElement passwordB;

        [FindsBy(How = How.CssSelector, Using = "button[data-track='Sign In']")]
        private IWebElement btnLoginB;


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void login()
        {
            Thread.Sleep(3000);
            linkLogin.Click();
            Thread.Sleep(2000);
            elements.Click();
            Thread.Sleep(2000);
            //emailB.SendKeys("");
            Thread.Sleep(1000);
            //passwordB.SendKeys("");
            Thread.Sleep(4000);
            btnLoginB.Click();
            Thread.Sleep(9000);
        }
    }
}
