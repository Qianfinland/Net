using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        { 
            //navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuateTest()
        {
            //find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform ops
            element.SendKeys("excuteautomation");

            Console.WriteLine("Execute Test:");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
