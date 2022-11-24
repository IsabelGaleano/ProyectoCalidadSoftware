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
            Thread.Sleep(4000);
        }
    }
}
