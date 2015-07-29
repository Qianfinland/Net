using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        public static string GetText(string element, string elementtype)
        {
            if (elementtype == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetTextFromDropDown(string element, string elementtype)
        {
            if (elementtype == "Id")
                //return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().ToString();//return 2 not Ms.??
                //return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectedOption.ToString();//2 nit Ms.??
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectedOption.Selected.ToString();//2 not Ms.??
            if (elementtype == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
