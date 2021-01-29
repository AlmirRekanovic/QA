using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{

    [TestFixture]
    public class Registration
    {

        IWebDriver driver;
        

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://olx.ba");
        }

        public void RegisterUser(string email, string password, string name) {
            driver.FindElement(By.XPath("html/body/div[2]/header/div/div/div/div/div/a[2]")).Click();
            driver.FindElement(By.XPath("html/body/div/header/div/div/div/div/div/div/div/a")).Click();
            driver.FindElement(By.XPath("html/body/div/div/div/div/div/div[2]/div/a")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='reg-password']")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@id='reg-username']")).SendKeys("fwfwbhwvwcw");
            driver.FindElement(By.XPath("//img[contains(@src,'female')]")).Click();
            driver.FindElement(By.XPath("//*[@id='cookiesBar']/p/button")).Click();
            driver.FindElement(By.XPath("//*[@id='kanton']")).Click();
            driver.FindElement(By.XPath("//option[@value='9']")).Click();
            driver.FindElement(By.Id("mjesto")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Trnovo')]")).Click();
            driver.FindElement(By.Id("tos")).Click();
            driver.FindElement(By.XPath("//button[@class='btn s']")).Click();
            driver.FindElement(By.XPath("//button[@class='btn s']")).FindElement(By.XPath(""));
        }
        public void VerifyThatUserIsRegistered(string name)
        {
            Assert.True(driver.FindElement(By.XPath($"//strong[text()='{name}']")).Displayed);
            driver.FindElement(By.Id(""));
        }

        [Test]
        public void VerifyThatUserCanRegisterTest()
        {
            string email = "fafafafq@sdada.com";
            string name = "iqphjq";
            string password = "Password!";

            RegisterUser(email, name, password);
            VerifyThatUserIsRegistered(name);




            //driver.Navigate().GoToUrl("https://www.saucedemo.com/index.html");
            //driver.FindElement(By.XPath("//*[@id='user-name']")).SendKeys("standard_user");
            //driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("secret_sauce");
            //driver.FindElement(By.XPath("//*[@id='login-button']")).Click();
            //driver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[1]/div[3]/button")).Click();
            //driver.FindElement(By.XPath("//*[@id='shopping_cart_container']")).Click();
            //driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[2]/a[2]")).Click();
            //driver.FindElement(By.XPath("//*[@id='first-name']")).SendKeys("First");
            //driver.FindElement(By.XPath("//*[@id='last-name']")).SendKeys("Lats");
            //driver.FindElement(By.XPath("//*[@id='postal-code']")).SendKeys("123");
            //driver.FindElement(By.XPath("//*[@id='checkout_info_container']/div/form/div[2]/input")).Click();
            //driver.FindElement(By.XPath("//*[@id='checkout_summary_container']/div/div[2]/div[8]/a[2]")).Click();
            //Assert.True(driver.FindElement(By.XPath("//*[@id='checkout_complete_container']/h2")).Displayed);


        }

        [Test]
        public void VerifyThatUserCanRegisterTest2()
        {

            driver.Navigate().GoToUrl("https://olx.ba");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("html/body/div[2]/header/div/div/div/div/div/a[2]")).Click();
            driver.FindElement(By.XPath("html/body/div/header/div/div/div/div/div/div/div/a")).Click();
            driver.FindElement(By.XPath("html/body/div/div/div/div/div/div[2]/div/a")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(" ");
            driver.FindElement(By.XPath("//input[@id='reg-password']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@id='reg-username']")).SendKeys("");
            driver.FindElement(By.XPath("//img[contains(@src,'female')]")).Click();
            driver.FindElement(By.XPath("//*[@id='cookiesBar']/p/button")).Click();
            driver.FindElement(By.XPath("//*[@id='kanton']")).Click();
            driver.FindElement(By.XPath("//option[@value='9']")).Click();
            driver.FindElement(By.Id("mjesto")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Trnovo')]")).Click(); 
            driver.FindElement(By.Id("tos")).Click(); 
            driver.FindElement(By.XPath("//button[@class='btn s']")).Click(); 


        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
