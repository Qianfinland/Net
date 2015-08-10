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
            /*driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); // wait page to load fully and solve error on no such element 
            //method 1 to find the image text 
            //var imagetext = driver.FindElement(By.LinkText("Kuvahaku"));

            //method 2 to find the image text
            var imagetext = driver.FindElement(By.Id("hdtb-msb")).FindElements(By.CssSelector("[class='hdtb-mitem hdtb-imb'"))[0].FindElement(By.TagName("a"));
            */

            //second method to wait elements to load 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var imagetext = wait.Until(d =>
                {
                    var elements = driver.FindElement(By.Id("hdtb-msb")).FindElements(By.CssSelector("[class='hdtb-mitem hdtb-imb'"));
                    if (elements.Count() > 0)
                        return elements[0].FindElement(By.TagName("a"));
                    return null;
                });
            Assert.That(imagetext.Text, Is.EqualTo("Kuvahaku"));
            imagetext.Click();

            //search a specific image, for example the 4th one 
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); //avoid error on no such element
            var imagelistId = driver.FindElement(By.Id("rg_s"));
            var fouthdivclass = imagelistId.FindElements(By.CssSelector("[class='rg_di rg_el ivg-i']"))[3];
            fouthdivclass.Click();
            var ImageLink = driver.FindElement(By.LinkText("Näytä kuva"));
            ImageLink.Click();
        }      

    }
}
