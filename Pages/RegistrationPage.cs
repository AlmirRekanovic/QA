using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Pages
{
    public class RegistrationPage : BasePage
    {
        #region Elements
        IWebElement LoginButton => driver.FindElement(By.XPath("html/body/div[2]/header/div/div/div/div/div/a[2]"));
        IWebElement RegisterButton => driver.FindElement(By.XPath("html/body/div/header/div/div/div/div/div/div/div/a"));
        #endregion

        #region Constructor
        public RegistrationPage(IWebDriver driver) : base(driver) { }
        #endregion

        #region Methods
        public RegistrationPage RegisterUser(string email, string password, string name)
        {
            LoginButton.Click();
            RegisterButton.Click();
            driver.FindElement(By.XPath("html/body/div/div/div/div/div/div[2]/div/a")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='reg-password']")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@id='reg-username']")).SendKeys(name);
            driver.FindElement(By.XPath("//img[contains(@src,'female')]")).Click();
            driver.FindElement(By.XPath("//*[@id='cookiesBar']/p/button")).Click();
            driver.FindElement(By.XPath("//*[@id='kanton']")).Click();
            driver.FindElement(By.XPath("//option[@value='9']")).Click();
            driver.FindElement(By.Id("mjesto")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Trnovo')]")).Click();
            driver.FindElement(By.Id("tos")).Click();
            driver.FindElement(By.XPath("//button[@class='btn s']")).Click();

            return new RegistrationPage(driver);
        }

        public VodicPage VerifyThatUserIsRegistered(string name)
        {
            Assert.True(driver.FindElement(By.XPath($"//strong[text()='{name}']")).Displayed, "yus");
            
            return new VodicPage(driver);
        }
        #endregion
    }
}
