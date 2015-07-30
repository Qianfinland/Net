using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //extended method from entering text in the control
        //Method for Enter Text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //click into a button, cCheckbox, options etc
        public static void ClickExtension(this IWebElement element)
        {
            //element.Click(); 
            //page navigation doesn't work if we use Click
            //OpenQA.Selenium.NoSuchElementException : Could not find element by: By.Name: Initial
            element.Submit();
        }

        //select a drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }
    }
}
