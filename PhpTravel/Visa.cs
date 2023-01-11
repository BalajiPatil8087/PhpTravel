using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PhpTravel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel
{
    public class Visa : AutomationWrapper
    {
        [Test]
        public void VisaBookTest()
        {
            driver.FindElement(By.XPath("//span[text()='visa']")).Click();
            driver.FindElement(By.Id("select2-from_country-container")).Click();
            driver.FindElement(By.XPath("//input[@class='select2-search__field']")).SendKeys("Albania");



            driver.FindElement(By.Id("date")).Click();
           
           SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("select2-to_country-container")));
            dropdown.SelectByText("Afghanistan");

            driver.FindElement(By.XPath("//span[text()='Afghanistan']")).Click();
        }
    }
}
