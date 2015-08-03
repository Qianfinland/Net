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

        [Test]
        public void MultiplyTwoNumbers()
        {
            //call the multiply method 
            string result = page.Multiply("2", "10");
            Assert.That(result, Is.EqualTo("20"));
        }

        [Test]
        public void DivideTwoNumbers()
        {
            string result = page.Divide("10", "2");
            Assert.That(result, Is.EqualTo("5"));
        }

        [Test]
        public void ModuleTwoNumbers()
        {
            string result = page.Module("9", "3");
            Assert.That(result, Is.EqualTo("0"));
        }
    }
}
