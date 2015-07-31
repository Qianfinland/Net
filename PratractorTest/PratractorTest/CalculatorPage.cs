using OpenQA.Selenium;
using Protractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratractorTest
{
    class CalculatorPage
    {
        private NgWebDriver _ngDriver;

        public CalculatorPage(IWebDriver driver, string url)
        {
            _ngDriver = new NgWebDriver(driver);
            _ngDriver.Url = url;
        }

        public string Add(string first, string second)
        {
            _ngDriver.FindElement(NgBy.Input("first")).SendKeys(first);
            _ngDriver.FindElement(NgBy.Input("second")).SendKeys(second);
            _ngDriver.FindElement(By.Id("gobutton")).Click();
            var latestSum = _ngDriver.FindElement(NgBy.Binding("latest")).Text;
            return latestSum;
        }
    }
}
