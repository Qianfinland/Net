using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDropDown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
