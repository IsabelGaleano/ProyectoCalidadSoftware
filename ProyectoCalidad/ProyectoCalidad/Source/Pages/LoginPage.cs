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

        [FindsBy(How = How.ClassName, Using = "isUGLz")]
        private IList<IWebElement> elements;

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement btnLogin;

        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_signin']")]
        private IWebElement linkLoginW;

        [FindsBy(How = How.ClassName, Using = "sign-in-btn")]
        private IWebElement elementsL;

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

        public void login(string vemail, string vpassword)
        {
            linkSignIn.Click();
            Thread.Sleep(2000);
            IWebElement element = elements[0];
            element.Click();
            Thread.Sleep(4000);
            email.SendKeys(vemail);
            password.SendKeys(vpassword);
            Thread.Sleep(4000);
            btnLogin.Click();
            Thread.Sleep(9000);
        }

        public void loginWalmart()
        {
            Thread.Sleep(3000);
            linkLoginW.Click();
            Thread.Sleep(2000);
            elementsL.Click();
            Thread.Sleep(2000);
            emailB.SendKeys("isagaleano9@gmail.com");
            Thread.Sleep(1000);
            passwordB.SendKeys("Isabel0806!");
            Thread.Sleep(4000);
            btnLoginB.Click();
            Thread.Sleep(9000);
        }
    }
}
