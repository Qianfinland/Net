using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            
        }  
   


        [Test]
        public void Selenium_Server_Test()
        {
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Firefox());
            driver.Url = "http://www.google.com";
            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Lotus flower");
            searchBox.SendKeys(Keys.Enter);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            var imagetext = driver.FindElement(By.LinkText("Kuvahaku"));
            Assert.That(imagetext.Text, Is.EqualTo("Kuvahaku"));
            imagetext.Click();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); //avoid error on no such element
            var imagelistId = driver.FindElement(By.Id("rg_s"));
            var fouthdivclass = imagelistId.FindElements(By.CssSelector("[class='rg_di rg_el ivg-i']"))[1].FindElement(By.TagName("a"));
            fouthdivclass.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            var ImageLink = driver.FindElement(By.LinkText("Näytä kuva"));
            ImageLink.Click();
        }

    }
}
