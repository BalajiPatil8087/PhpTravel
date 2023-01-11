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
    public class LoginUITest : AutomationWrapper
    {
        [Test]
        public void ValidateTitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("PHPTRAVELS | Travel Technology Partner - PHPTRAVELS"),"wrong");

        }

        [Test]
        public void ValidateLogoTest()
        {
            bool LogoPresent=driver.FindElement(By.XPath("//img[@alt='logo']")).Displayed;
            Assert.IsTrue(LogoPresent);
            
        }

        [Test]
        public void ValidateSearchTextBoxTest()
        {
           bool searchTextBox= driver.FindElement(By.XPath("//span[text()=' Search by City']")).Displayed;
            Assert.IsTrue(searchTextBox);
        }

        [Test]
        public void ValidateCalenderTest()
        {
           bool calender= driver.FindElement(By.Name("checkin")).Displayed;
            Assert.IsTrue(calender);
        }
        [Test]
        public void ValidateCalenderTest1()
        {
            bool calender = driver.FindElement(By.Name("checkout")).Displayed;
            Assert.IsTrue(calender);
        }
        [Test]
        public void TravellersTest()
        {
            bool travel=driver.FindElement(By.XPath("//p[text()='Travellers ']")).Displayed;
            Assert.IsTrue(travel);
        }
        [Test]
        public void SearchBoxTest()
        {
            bool SearchBox = driver.FindElement(By.XPath("(//button[@class='more_details effect btn btn-primary btn-block btn-lg ladda-button waves-effect'])[1]")).Displayed;
            Assert.IsTrue(SearchBox);
        }
    }
}
