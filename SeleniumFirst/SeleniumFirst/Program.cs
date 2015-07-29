using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        { 
            //create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();
            //navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuateTest()
        {
            //EnterText(element, value, type of control By.)
            //Title
            SeleniumSetMethods.SelectDropDown( "TitleId", "Ms.", "Id");

            //Initial
            SeleniumSetMethods.EnterText( "Initial", "test", "Name");

            //check the get method
            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText("TitleId", "Id")); //2??
            //Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetTextFromDropDown("TitleId", "Id"));//true
            Console.WriteLine("The value form my Initial is:" + SeleniumGetMethods.GetText("Initial", "Name"));
            //Click
            SeleniumSetMethods.Click( "Save", "Name");
            Console.WriteLine("Execute Test:");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
