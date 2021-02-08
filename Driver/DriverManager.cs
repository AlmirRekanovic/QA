using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Driver
{
    public class DriverManager
    {
        public IWebDriver CreateDriver(string browser)
        {
            IWebDriver driver;

            switch (browser)
            {
                case "iexplorer":
                    driver = new InternetExplorerDriver();
                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
                    driver = new FirefoxDriver(service);
                    break;
                //driver = new FirefoxDriver();
                //break;
                default:
                    driver = new ChromeDriver();
                    break;

            }

            return driver;
        }
    }
}
