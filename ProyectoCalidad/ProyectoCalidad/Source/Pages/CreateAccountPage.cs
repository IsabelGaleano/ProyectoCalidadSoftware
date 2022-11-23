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


        [FindsBy(How = How.XPath, Using = "//*[@id='headerPrimary']/a[4]")]
        private IWebElement linkSignIn;

        [FindsBy(How = How.ClassName, Using = "isUGLz")]
        private IList<IWebElement> elements;

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement name;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement lastname;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "createAccount")]
        private IWebElement btnCreateAccount;

        [FindsBy(How = How.Id, Using = "keepMeSignedIn")]
        private IWebElement keepMeSignedIn;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void createAccount()
        {
            linkSignIn.Click();
            Thread.Sleep(2000);
            IWebElement element = elements[1];
            element.Click();
            Thread.Sleep(2000);
            email.SendKeys("luwiisabel@gmail.com");
            name.SendKeys("Isabel");
            lastname.SendKeys("Galeano");
            password.SendKeys("Gatos123!");
            Thread.Sleep(2000);
            btnCreateAccount.Click();
            Thread.Sleep(4000);
        }
    }
}
