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

        public string ReturnResult()
        {
            return _ngDriver.FindElement(NgBy.Binding("latest")).Text; 
        }

        private void SetOperator(string opera)
        {
            var operatorSelect = new SelectElement(_ngDriver.FindElement(NgBy.Select("operator")));
            operatorSelect.SelectByText(opera);
        }
        public string Add(string first, string second)
        {
            DoMath(first, second);
            SetOperator("+");
            Click();
            return ReturnResult();
        }

        public string Substract(string first, string second)
        {
            DoMath(first, second);
            //var operatorSelect = new SelectElement(_ngDriver.FindElement(NgBy.Select("operator")));
            //operatorSelect.SelectByText("-");
            SetOperator("-");
            Click();
            return ReturnResult();
        }

        public string Multiply(string first, string second)
        {
            DoMath(first, second);
            SetOperator("*");
            Click();
            return ReturnResult();
        }

        public string Divide(string first, string second)
        {
            DoMath(first, second);
            SetOperator("/");
            Click();
            return ReturnResult();
        }

        public string Module(string first, string second)
        {
            DoMath(first, second);
            SetOperator("%");
            Click();
            return ReturnResult();
        }

    }
}
