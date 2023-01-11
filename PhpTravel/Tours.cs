using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
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
            driver.FindElement(By.XPath(""));
        }
    }
}
