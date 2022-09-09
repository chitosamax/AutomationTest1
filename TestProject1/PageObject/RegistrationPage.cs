using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Utilities;

namespace TestProject1.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        internal void EnterUsername()
        {
            throw new NotImplementedException();
        }

        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));


        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername(string username)
        {
            Username.SendKeys("Samax");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            Email.SendKeys("Samax@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("sureboy");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }


    }
}
