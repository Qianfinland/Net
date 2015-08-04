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
        static void Main(string[] args)
        {
            //case of Firefox
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "www.google.com";

            ////case of IE
            //IWebDriver driver1 = new InternetExplorerDriver(@"C:\Users\Qian.Zhou\Documents\");
            //driver1.Url = "www.facebook.com";

            //case for Chrome
            IWebDriver driver = new ChromeDriver(@"C:\Users\Qian.Zhou\Documents\");
            driver.Url = "http://www.google.com";
            //driver.Navigate().GoToUrl("http://www.google.com");//same as above 
            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Selenium C# tutorial");
        }


    }
}
