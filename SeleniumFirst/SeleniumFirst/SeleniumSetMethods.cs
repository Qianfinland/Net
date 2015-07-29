using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Method for Enter Text
        public static void EnterText(string element, string value, string elementtype)
        {
            if(elementtype == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click into a button, cCheckbox, options etc
        public static void Click( string element, string elementtype)
        {
            if(elementtype == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //select a drop down control
        public static void SelectDropDown(string element, string value,string elementtype)
        {
            //SelectElement SELECTeLEMENT = new SelectElement();
            if (elementtype == "Id")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        }
    }
}
