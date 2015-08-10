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
            { var homePage = new HomePage();
            return homePage;
            }
        }

        
    }

    public class HomePage
    {
        static string Url = "http://pluralsight.com";
        private static string PageTitle = "Pluralsight – Developer, IT & Creative Training by Pros";
        public void Goto()
        {
            Browser.Goto(Url);
        }


        public  bool IsAt()
        {
            return Browser.Title == PageTitle;
        }
    }
}
