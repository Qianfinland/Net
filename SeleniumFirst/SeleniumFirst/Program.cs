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

            //login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA= pageLogin.Login("bunny","guessmypassword");

            //pageEA.TextInitial.SendKeys("Test page navigation");
            //pageEA.TextFirstName.SendKeys("Bunny");
            //pageEA.TextMiddleName.SendKeys("Smith");
            //pageEA.ButtonSave.Click();

            //call the user fill form operation from the EAPageObject 
            pageEA.UserFormFill("call userFormFill method from EAPageObject", "Bunny", "Smith");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");
        }
    }
}
