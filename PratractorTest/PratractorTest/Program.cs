using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratractorTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        const string url = "http://juliemr.github.io/protractor-demo/";
        IWebDriver driver;
        CalculatorPage page;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            page = new CalculatorPage(driver, url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void AddTwoNumbers()
        {
            //call the add method 
             string result = page.Add("5", "6");
             Assert.That(result, Is.EqualTo("11"));

             string result1 = page.Add("1", "6");
             Assert.That(result1, Is.EqualTo("7"));
        }

        [Test]
        public void SubstractTwoNumbers()
        {
            //call the substract method 
            string result = page.Substract("9", "8");
            Assert.That(result, Is.EqualTo("1"));

            string result1 = page.Substract("10", "5");
            Assert.That(result1, Is.EqualTo("5"));
        }
    }
}
