using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProyectoCalidad.Source.Pages
{
    public class CreateAccountPage
    {
        private IWebDriver driver;


        [FindsBy(How = How.CssSelector, Using = "button[data-lid='hdr_signin']")]
        private IWebElement linkLogin;

        [FindsBy(How = How.ClassName, Using = "create-account-btn")]
        private IWebElement linkCreateAccount;

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstName;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastName;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "fld-p1")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "reenterPassword")]
        private IWebElement confirmPassword;

        [FindsBy(How = How.Id, Using = "phone")]
        private IWebElement phone;

        [FindsBy(How = How.CssSelector, Using = "button[data-track='Create Account']")]
        private IWebElement btnCreateAccount;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void createAccount(string vemail,string vname, string vlastname,string vpassword, string vphone)
        {
            linkLogin.Click();
            Thread.Sleep(1000);
            linkCreateAccount.Click();
            Thread.Sleep(5000);
            firstName.SendKeys(vname);
            Thread.Sleep(1000);
            lastName.SendKeys(vlastname);
            Thread.Sleep(1000);
            email.SendKeys(vemail);
            Thread.Sleep(1000);
            password.SendKeys(vpassword);
            Thread.Sleep(1000);
            confirmPassword.SendKeys(vpassword);
            phone.SendKeys(vphone);
            Thread.Sleep(4000);
            btnCreateAccount.Click();
            Thread.Sleep(7000);
        }
    }
}
