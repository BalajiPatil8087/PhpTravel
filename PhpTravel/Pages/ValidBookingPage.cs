using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel.Pages
{
    public class ValidBookingPage
    {
        private By _FlyingFromLocator = By.Id("autocomplete");
        private By _ToDestinationLocator = By.Id("autocomplete2");
        private By _clickLocator = By.Id("departure");
        private By _datelocator = By.Id("departure");
        private By _TravellersLocator = By.XPath("//p[contains(text(),'Travellers ')]");
        private By _ClickOnTravellersLocator = By.XPath("//i[@class='la la-plus']");
        private By _searchlocator = By.Id("flights-search");

        private IWebDriver driver;

        public ValidBookingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void enterflyingfrom(string FlyingFrom)
        {
            driver.FindElement(_FlyingFromLocator).SendKeys(FlyingFrom);
        }

        public void EnterFrom(string ToDestination)
        {
            driver.FindElement(_ToDestinationLocator).SendKeys(ToDestination);
        }

        public void clickon()
        {
            driver.FindElement(_clickLocator).Click();
        }

        public void EnterDate(string DepartureDate)
        {
            driver.FindElement(_datelocator).SendKeys(DepartureDate);
        }

        public void clickTravellers()
        {
            driver.FindElement(_TravellersLocator).Click();
        }

        public void clickonTrav()
        {
            driver.FindElement(_ClickOnTravellersLocator).Click();
        }

        public void ClickOnsearch()
        {
            driver.FindElement(_searchlocator).Click();
        }
    }
}
