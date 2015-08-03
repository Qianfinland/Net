using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        private void DoMath(string first, string second)
        {
           _ngDriver.FindElement(NgBy.Input("first")).SendKeys(first);
           _ngDriver.FindElement(NgBy.Input("second")).SendKeys(second);
        }

        private void Click()
        {
            _ngDriver.FindElement(By.Id("gobutton")).Click();
        }
        public string Add(string first, string second)
        {
            DoMath(first, second);
            var operatorSelect = new SelectElement(_ngDriver.FindElement(NgBy.Select("operator")));
            operatorSelect.SelectByText("+");
            Click();
            var latestResult = _ngDriver.FindElement(NgBy.Binding("latest")).Text;
            return latestResult;
        }

        public string Substract(string first, string second)
        {
            DoMath(first, second);
            var operatorSelect = new SelectElement(_ngDriver.FindElement(NgBy.Select("operator")));
            operatorSelect.SelectByText("-");
            Click();
            var latestResult = _ngDriver.FindElement(NgBy.Binding("latest")).Text;
            return latestResult;
        }

    }
}
