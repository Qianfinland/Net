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
             page.Add("5", "6");
             Assert.That(page.ReturnResult(), Is.EqualTo("11"));
        }

        [Test]
        public void SubstractTwoNumbers()
        {
            //call the substract method 
            page.Substract("9", "8");
            Assert.That(page.ReturnResult(), Is.EqualTo("1"));

            page.Substract("10", "5");
            Assert.That(page.ReturnResult(), Is.EqualTo("5"));
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            page.Multiply("10", "2");
            Assert.That(page.ReturnResult(), Is.EqualTo("20"));
        }

        [Test]
        public void DivideTwoNumbers()
        {
            page.Divide("10", "2");
            Assert.That(page.ReturnResult(), Is.EqualTo("5"));
        }

        [Test]
        public void ModuleTwoNumbers()
        {
            page.Module("9", "3");
            Assert.That(page.ReturnResult(), Is.EqualTo("0"));
        }
    }
}
