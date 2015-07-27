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
        static void Main(string[] args)
        {
            //create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform ops
            element.SendKeys("excuteautomation");
        }
    }
}
