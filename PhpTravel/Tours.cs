using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using PhpTravel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel
{
    public class Tours : AutomationWrapper
    {
        [Test]
        public void ValidateToursTest()
        {
            driver.FindElement(By.XPath("//span[text()='Tours']")).Click();
            driver.FindElement(By.XPath("//input[@class=\"select2-search__field\"]")).Click();

            driver.ExecuteJavaScript("document.querySelector('#select2-tours_city-container').value='Pune,India';\r\n");
            Thread.Sleep(2000);
            driver.ExecuteJavaScript("document.querySelector('#date').value='21-01-2023'");

            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();

            driver.FindElement(By.XPath("//button[@class='more_details w-100 btn-lg effect ladda-button waves-effect']")).Click();

        }
    }
}
