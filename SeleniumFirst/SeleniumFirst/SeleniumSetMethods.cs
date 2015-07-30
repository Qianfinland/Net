using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Method for Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //click into a button, cCheckbox, options etc
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //select a drop down control
        public static void SelectDropDown(IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }
    }
}
