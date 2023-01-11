using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium;
using PhpTravel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PhpTravel
{
    public class Visa : AutomationWrapper
    {
        [Test]
        public void VisaBook()
        {
            driver.FindElement(By.XPath("//span[text()='visa']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("select2-from_country-container")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//span[@id=\"select2-from_country-container\"]")).Click();


            //  driver.FindElement(By.Id("select2-to_country-container")).Click();
            //  driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Algeria");
            driver.ExecuteJavaScript("document.querySelector('#date').value='24-01-2023'\r\n");
            // driver.FindElement(By.Id("date")).SendKeys("19-01-2023");

        }
    }
}
