using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace TestProjectGoogleImageTest1
{
    public class Tests
    {
        private IWebDriver _driver;

        


        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.google.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        
        {
            var ImagePresent = _driver.FindElement(By.XPath("//img[@class='lnXdpd']"));
            _ = ImagePresent.Displayed;

            
        }
    

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}