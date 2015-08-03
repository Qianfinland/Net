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
        private void DoMath(string first, string second, string opera)
        {
           _ngDriver.FindElement(NgBy.Input("first")).SendKeys(first);
           _ngDriver.FindElement(NgBy.Input("second")).SendKeys(second);
           SetOperator(opera);
           Click();
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
        public void Add(string first, string second)
        {
            DoMath(first, second, "+");
            //return ReturnResult();
        }

        public void Substract(string first, string second)
        {
            DoMath(first, second, "-");
        }

        public void Multiply(string first, string second)
        {
            DoMath(first, second, "*");
        }

        public void Divide(string first, string second)
        {
            DoMath(first, second, "/");
        }

        public void Module(string first, string second)
        {
            DoMath(first, second, "%");
        }

    }
}
