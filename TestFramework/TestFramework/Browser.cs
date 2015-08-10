using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static string Title
        {
            get { return webDriver.Title; } 
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
