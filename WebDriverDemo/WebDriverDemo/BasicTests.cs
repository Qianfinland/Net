using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class BasicTests
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Qian.Zhou\Documents\");


        [Test]
        public void DifferentElementsTest()
        {
            driver.Url = @"file:///C:/Users/Qian.Zhou/Documents/Visual%20Studio%202013/Projects/c%23/WebDriverDemo/TestPage.html";

            //radiobutton
            var radioButtons = driver.FindElements(By.Name("color"));
            foreach (var radiobutton in radioButtons)
            {
                Console.WriteLine(radiobutton.GetAttribute("value"));
            }

            //checkbox
            var checkBox = driver.FindElement(By.Id("check1"));
            checkBox.Click();
            //checkBox.Click(); //uncheck

            //select items
            var select = driver.FindElement(By.Id("select1"));

            ////method 1 to select the 3rd element
            //var tom = select.FindElements(By.TagName("option"))[2];
            //tom.Click();

            //method 2 use SelectElement to select the 2nd 
            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Robert");

            //tables
            ////method 1 to find the 2nd row :table tag -> 2nd table tag -> td
            //var firsttable = driver.FindElement(By.TagName("table"));
            //var secondtable = firsttable.FindElement(By.TagName("table"));
            //var row2 = secondtable.FindElements(By.TagName("td"))[1];
            //Assert.That(row2.Text, Is.EqualTo("Table row 2"));

            //method 2 to find the 2nd row with Xpath: table/tr/td[1]/table/tr[1]/td
            var row2 = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Assert.That(row2.Text, Is.EqualTo("Table row 2"));
        }
    }

}
