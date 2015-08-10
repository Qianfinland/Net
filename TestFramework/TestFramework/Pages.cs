using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }
     }

        
    
    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight – Developer, IT & Creative Training by Pros";

        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement authorLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }


        public  bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {
            authorLink.Click();
            var author = Browser.Driver.FindElement(By.LinkText(authorName));
            author.Click();
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorPage.AuthorName == authorName;
        }
    }

    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "html#ng-app.js.touch.svg.inlinesvg.svgclippaths.no-ie8compat.ng-scope body div.ng-scope div.ng-scope section.hero div.row.author-header div.small-12.large-10.medium-9.columns.pull-over h1.hero-title.ng-binding")]
        private IWebElement authorName;
        public string AuthorName 
        {
            get { return authorName.Text; } 
        }
    }
}
