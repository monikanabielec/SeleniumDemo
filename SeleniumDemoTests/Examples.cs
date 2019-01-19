using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTests
{
    [TestFixture]
    public class Examples
    {
        private IWebDriver driver = new FirefoxDriver();
        public void Example()
        {
            //wypełnianie formularza
            var searchTextBox = driver.FindElement(By.Name("q"));
            searchTextBox.SendKeys("Test" + Keys.Enter);
            //inne obiekty
            var education = driver.FindElement(By.Name("education"));
            //stworzenie obiektu
            var selectElement = new SelectElement(education);
            //wybranie wartosci
            selectElement.SelectByValue("Jr.High");
            //czekanie na element
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
          .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.CssSelector("div.hdtb - mitem:nth - child(1)"))));
            //sprawdzenie wartosci
            StringAssert.StartsWith("Test", driver.Title);
        }
    }
}
}
