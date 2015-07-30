using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;

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
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuateTest()
        {
            //intialize the excel sheet
            ExcelLib.PopulateInCollection(@"C:\Users\Qian.Zhou\Documents\DataSelenium.xlsx");
            //login to application
            LoginPageObject pageLogin = new LoginPageObject();
            //EAPageObject pageEA= pageLogin.Login("bunny","guessmypassword");
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            
            //pageEA.TextInitial.SendKeys("Test page navigation");
            //pageEA.TextFirstName.SendKeys("Bunny");
            //pageEA.TextMiddleName.SendKeys("Smith");
            //pageEA.ButtonSave.Click();

            //call the user fill form operation from the EAPageObject 
            //pageEA.UserFormFill("test", "Bunny", "Smith");
            pageEA.UserFormFill(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"));
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
