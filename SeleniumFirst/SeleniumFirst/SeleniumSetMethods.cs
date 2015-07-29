using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Method for Enter Text
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if(elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click into a button, cCheckbox, options etc
        public static void Click( string element, PropertyType elementtype)
        {
            if(elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //select a drop down control
        public static void SelectDropDown(string element, string value,PropertyType elementtype)
        {
            //SelectElement SELECTeLEMENT = new SelectElement();
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        }
    }
}
