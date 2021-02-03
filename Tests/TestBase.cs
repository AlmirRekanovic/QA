using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using proba.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Tests
{
    public class TestBase
    {
        public IWebDriver driver;
        public LoginPage basePage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://olx.ba");
            basePage = new LoginPage(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
