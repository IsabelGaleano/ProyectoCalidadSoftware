using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    
    public class SignOutPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_signin']")]
        private IWebElement btnHdrSignIn;

        [FindsBy(How = How.Id, Using = "logout-button")]
        private IWebElement btnSignOut;

        public SignOutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void signOut(string vemail, string vpassword)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.login(vemail,vpassword);
            Thread.Sleep(3000);
            btnHdrSignIn.Click();
            Thread.Sleep(2000);
            btnSignOut.Click();
            Thread.Sleep(7000);

        }
    }
}
