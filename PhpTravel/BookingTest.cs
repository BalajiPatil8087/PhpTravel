using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PhpTravel.Base;
using PhpTravel.Pages;
using PhpTravel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel
{
    public class BookingTest : AutomationWrapper
    {

        [Test]
        public void ValidBookingTest()
        {

            driver.FindElement(By.XPath("//a[text()='flights']")).Click();
 
            driver.FindElement(By.Id("autocomplete")).SendKeys("PNQ");
            driver.FindElement(By.XPath("//b[text()='PNQ']")).Click();

            driver.FindElement(By.Id("autocomplete2")).SendKeys("BLR");
            driver.FindElement(By.XPath("//b[text()='BLR']")).Click();

            driver.FindElement(By.Id("departure")).Clear();
            driver.FindElement(By.Id("departure")).SendKeys("7-01-2023");
            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();
            driver.FindElement(By.Id("flights-search")).Click();
          
        }

        [Test, TestCaseSource(typeof(Datasource), nameof(Datasource.ValidBookingData))]
        public void ValidBookingdata(string FlyingFrom, string ToDestination, string DepartureDate)
        {

            driver.FindElement(By.XPath("//a[text()='flights']")).Click();

            ValidBookingPage Bookingpage = new ValidBookingPage(driver);
            Bookingpage.enterflyingfrom(FlyingFrom);
            Bookingpage.EnterFrom(ToDestination);
            Bookingpage.EnterDate(DepartureDate);
            Bookingpage.clickTravellers();
            Bookingpage.clickon();
            Bookingpage.ClickOnsearch();
            Bookingpage.clickonTrav();
            

            //driver.FindElement(By.Id("autocomplete")).SendKeys(FlyingFrom);
            // driver.FindElement(By.XPath("//b[text()='']")).Click();

            /*driver.FindElement(By.Id("autocomplete2")).SendKeys(ToDestination);
            //driver.FindElement(By.XPath("//b[text()='BLR']")).Click();

            driver.FindElement(By.Id("departure")).Clear();
            driver.FindElement(By.Id("departure")).SendKeys(DepartureDate);
            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();
            driver.FindElement(By.Id("flights-search")).Click();*/
        }



        [Test, TestCaseSource(typeof(Datasource), nameof(Datasource.BookingValidData))]
        public void BookingValidData(string FlyingFrom, string ToDestination, string DepartureDate)
        {
            driver.FindElement(By.XPath("//a[text()='flights']")).Click();

            driver.FindElement(By.Id("autocomplete")).SendKeys(FlyingFrom);
           
            driver.FindElement(By.Id("autocomplete2")).SendKeys(ToDestination);
           

            driver.FindElement(By.Id("departure")).Clear();
            driver.FindElement(By.Id("departure")).SendKeys(DepartureDate);
            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();
            driver.FindElement(By.Id("flights-search")).Click();
        }

      

    }

}
