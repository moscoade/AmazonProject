using AmazonProject.Hooks;
using AmazonProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject.PageObject
{
    class AutomationPage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement helloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));
        IWebElement profilePage => driver.FindElement(By.XPath("//h1[@class='a-spacing-small']"));
        IWebElement createAmazonAccount => driver.FindElement(By.XPath("//a[@id='createAccountSubmit']"));
        IWebElement accountPage => driver.FindElement(By.XPath("//h1[@class='a-spacing-small']"));
        IWebElement name => driver.FindElement(By.XPath("//input[@type='text']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@id='ap_password']"));
        IWebElement repassword => driver.FindElement(By.XPath("//input[@id='ap_password_check']"));
        IWebElement creatAccount => driver.FindElement(By.XPath("//input[@type='submit']"));
        IWebElement clickContinue => driver.FindElement(By.XPath("//input[@type='submit']"));
        IWebElement signIn => driver.FindElement(By.XPath("//input[@id='signInSubmit']"));
        IWebElement yourAmazonPage => driver.FindElement(By.XPath("//div[@id='nav-xshop']"));

        public void YourAmazonPageIsDisplay()
        {
            if (yourAmazonPage.Displayed)
            {
                Assert.That(yourAmazonPage.Displayed, Is.True);
            }
        }

        public void ClickSignIn()
        {
            signIn.Click();
        }
        public void ClickContinue()
        {
            clickContinue.Click();
        }
        public void CreateAmazonAccount()
        {
            creatAccount.Click();
        }
        public void RePassword(string RePwd)
        {
            repassword.SendKeys(RePwd);
        }
        public void EnterPassword(string Pwd)
        {
            password.SendKeys(Pwd);
        }

        public void EnterEmail()
        {
            email.SendKeys("moscoade1@gmail.com");
        }
        public void EnterMyName()
        {
            name.SendKeys("Moses Ade");
        }
        public void AccountPageIsDisplay()
        {
            if (accountPage.Displayed)
            {
                Assert.That(accountPage.Displayed, Is.True);
            }
        }

        public void CreateYourAmazonAccount()
        {
            createAmazonAccount.Click();
        }

        public void ProfilePageIsDisplay()
        {
           if (profilePage.Displayed)
           {
                Assert.That(profilePage.Displayed, Is.True);
           }
        }
        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }
        public void NavigateToTheWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }
        public AutomationPage()
        {
            driver = Hook.driver;
        }

       
    }
}
