using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
        public void SearchGoogleImageTest()
        {
            driver.Url = "http://www.google.com";
            //driver.Navigate().GoToUrl("http://www.google.com");//same as above
 
            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Pluralsight");
            searchBox.SendKeys(Keys.Enter); // Use the enter key 


            //clcik the image
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15)); // wait page to load fully and solve error on no such element 
            //method 1 to find the image text 
            //var imagetext = driver.FindElement(By.LinkText("Kuvahaku"));

            //method 2 to find the image text
            //var imagetext = driver.FindElement(By.Id("hdtb-msb")).FindElements(By.CssSelector("[class='hdtb-mitem hdtb-imb'"))[0].FindElement(By.TagName("a"));


            //second method to wait elements to load 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var imagetext = wait.Until(d =>
            {
                var elements = driver.FindElement(By.Id("hdtb-msb")).FindElements(By.CssSelector("[class='hdtb-mitem hdtb-imb'"));
                if (elements.Count() > 0)
                    return elements[0].FindElement(By.TagName("a"));
                return null;
            });
            Assert.That(imagetext.Text, Is.EqualTo("Kuvahaku"));
            imagetext.Click();

            //search a specific image, for example the 4th one 
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); //avoid error on no such element
            var imagelistId = driver.FindElement(By.Id("rg_s"));
            var fouthdivclass = imagelistId.FindElements(By.CssSelector("[class='rg_di rg_el ivg-i']"))[3];
            fouthdivclass.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            var ImageLink = driver.FindElement(By.LinkText("Näytä kuva"));
            ImageLink.Click();
        }

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
