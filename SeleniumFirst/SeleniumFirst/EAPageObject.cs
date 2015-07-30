using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject ()
	    {
            PageFactory.InitElements(PropertiesCollection.driver, this);
	    }
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DropDownTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TextInitial { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TextFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TextMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement ButtonSave { get; set; }

        //User fill form operation method
        public void UserFormFill(string initial, string firstname, string middlename)
        {
            //use of extension
            TextInitial.EnterText(initial);
            TextFirstName.EnterText(firstname);
            TextMiddleName.EnterText(middlename);
            ButtonSave.ClickExtension();

            //SeleniumSetMethods.EnterText(TextInitial, initial);
            //SeleniumSetMethods.EnterText(TextFirstName, firstname);
            //SeleniumSetMethods.EnterText(TextMiddleName, middlename);
            //SeleniumSetMethods.Click(ButtonSave);


            
            //TextInitial.SendKeys(initial);
            //TextFirstName.SendKeys(firstname);
            //TextMiddleName.SendKeys(middlename);
            //ButtonSave.Click();
        }
    }
}
