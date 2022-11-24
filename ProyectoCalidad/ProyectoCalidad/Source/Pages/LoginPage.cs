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


        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_signin']")]
        private IWebElement linkLogin;

        [FindsBy(How = How.ClassName, Using = "sign-in-btn")]
        private IWebElement btnSignIn;

        [FindsBy(How = How.Id, Using = "fld-e")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "fld-p1")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "button[data-track='Sign In']")]
        private IWebElement btnLogin;


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void login()
        {
            linkLogin.Click();
            Thread.Sleep(1000);
            btnSignIn.Click();
            Thread.Sleep(1000);
            //email.SendKeys("");
            Thread.Sleep(1000);
            //password.SendKeys("");
            Thread.Sleep(2000);
            btnLogin.Click();
            Thread.Sleep(6000);
        }
    }
}
