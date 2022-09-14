using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProjectGoogleImageTest1
{
    internal static class WebdriverExHelpers
    {

        public static IWebElement FindElementExist(this IWebDriver driver, By by, int timeoutInSeconds = 30)
        {
            var wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
            wait.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
            return wait.Until(d => driver.FindElement(by));
        }
    }
}