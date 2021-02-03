using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public LoginPage OpenLoginForm()
        {
            //driver.FindElement(By.XPath("html/body/div[2]/header/div/div/div/div/div/a[2]")).Click();

            return new LoginPage(driver);
        }
        public RegistrationPage SelectRegisterOption() {
            driver.FindElement(By.XPath("html/body/div[2]/header/div/div/div/div/div/a[2]")).Click();
            driver.FindElement(By.XPath("html/body/div/header/div/div/div/div/div/div/div/a")).Click();

            return new RegistrationPage(driver);
        }
    }
}
