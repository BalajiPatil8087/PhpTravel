using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravel.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            driver=new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            driver.Url = "https://phptravels.net/";
        }
        [TearDown]
        public void AfterMethod()
        {
            driver.Quit();
        }
    }
}
