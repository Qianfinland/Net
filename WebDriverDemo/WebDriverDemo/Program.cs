using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Qian.Zhou\Documents\");
        static void Main(string[] args)
        {
            //case of Firefox
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "www.google.com";

            ////case of IE
            //IWebDriver driver1 = new InternetExplorerDriver(@"C:\Users\Qian.Zhou\Documents\");
            //driver1.Url = "www.facebook.com";
            //case for Chrome
        }
        [Test]
        public void ImageSearchTest()
        {
            
            driver.Url = "http://www.google.com";
            //driver.Navigate().GoToUrl("http://www.google.com");//same as above 
            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Pluralsight");
            searchBox.SendKeys(Keys.Enter); // Use the enter key 


            //clcik the image
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); // wait page to load fully and solve error on no such element 
            var imagelink = driver.FindElement(By.LinkText("Kuvahaku"));
            imagelink.Click();

            //search a specific image, for example the 4th one  
            var imagelistId = driver.FindElement(By.Id("rg_s"));
            var fouthdivclass = imagelistId.FindElements(By.CssSelector("[class='rg_di rg_el ivg-i']"))[3];
            fouthdivclass.Click();
            var ImageLink = driver.FindElement(By.LinkText("Näytä kuva"));
            ImageLink.Click();
        }

        [Test]
        public void RadioButtonTest()
        {
            driver.Url = @"file:///C:/Users/Qian.Zhou/Documents/Visual%20Studio%202013/Projects/c%23/WebDriverDemo/TestPage.html";
            var radioButton = driver.FindElements(By.Name("color"))[0];
            radioButton.Click();
        }

    }
}
