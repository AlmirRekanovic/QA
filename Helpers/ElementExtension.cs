using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Helpers
{
    public static class ElementExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static bool WaitUntilClickable(this IWebElement element, IWebDriver driver, int numSec)
        {
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(numSec));

                    return wait.Until(drv =>
                    {
                        if (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element) != null)
                            return true;
                        return false;
                    });
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
