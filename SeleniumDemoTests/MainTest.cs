using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTests
{
    [TestFixture]
    public abstract class MainTest
    {
        public IWebDriver _driver { private set; get; }
        [SetUp]
        public void StartBrowser()
        {
            _driver = new FirefoxDriver();
        }
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
