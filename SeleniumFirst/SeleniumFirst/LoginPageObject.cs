using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement TextUserName { get; set; }

        [FindsBy(How = How.Name, Using="Password")]
        public IWebElement TextPassword { get; set; }

        [FindsBy(How = How.Name, Using="Login")]
        public IWebElement ButtonLogin { get; set; }

        //method for the login operation
        public EAPageObject Login(string userName, string password) 
        { 
            //username
            TextUserName.EnterText(userName); //extension method 
            //TextUserName.SendKeys(userName);
            //password
            TextPassword.EnterText(password); //extension method
            //TextPassword.SendKeys(password);
            //click the login button
            ButtonLogin.ClickExtension(); //extension method
            //ButtonLogin.Submit();

            //return the page object
            return new EAPageObject();
        }

    }
}
