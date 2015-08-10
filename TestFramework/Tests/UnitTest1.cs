using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Go_To_HomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void Go_To_AuthorPage()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectAuthor("Aaron Patterson");
            Assert.IsTrue(Pages.HomePage.IsAtAuthorPage("Aaron Patterson"));
        }
        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
