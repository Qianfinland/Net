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
        NgWebDriver ngDriver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            ngDriver = new NgWebDriver(driver);
        }

        [TearDown]
        public void TearDown()
        {
            ngDriver.Quit();
        }

        [Test]
        public void AddFourAndSix_ShouldBeTen()
        {
            //navigate to the url
            ngDriver.Url = url;
            ngDriver.FindElement(NgBy.Input("first")).SendKeys("1");
            ngDriver.FindElement(NgBy.Input("second")).SendKeys("2");
            ngDriver.FindElement(By.Id("gobutton")).Click(); // cannot use submit??? 
            var latestSum = ngDriver.FindElement(NgBy.Binding("latest")).Text;
            Assert.That(Int32.Parse(latestSum), Is.EqualTo(3));
        }
    }
}
