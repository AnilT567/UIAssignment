using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace UIAssignment.StepDefinitions
{
    [Binding]
    public class PreProcessor
    {


        private readonly IObjectContainer container;

        public PreProcessor(IObjectContainer container)
        {
            this.container = container;
        }



        [BeforeScenario()]
        public void CreateWebDriver()
        {
           
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // Create and configure a concrete instance of IWebDriver
            IWebDriver driver = new ChromeDriver();
            {

            };

            // Make this instance available to all other step definitions
            container.RegisterInstanceAs(driver);

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);

            //driver.Navigate().GoToUrl("https://www.bbc.com/sport/football/scores-fixtures");
        }

       

        [AfterScenario()]
        public void DestroyWebDriver()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();

            driver.Close();
            driver.Dispose();

        }

    }
}
