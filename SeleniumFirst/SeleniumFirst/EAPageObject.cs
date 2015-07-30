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
    }
}
