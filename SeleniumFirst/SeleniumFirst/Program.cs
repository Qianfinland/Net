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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuateTest()
        {
            //EnterText(element, value, type of control By.)
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Ms.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "test", "Name");

            //check the get method
            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));

            Console.WriteLine("The value form my Initial is:" + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
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
