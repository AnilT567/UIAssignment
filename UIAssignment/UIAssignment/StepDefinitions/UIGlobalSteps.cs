using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIAssignment.UIPages;

namespace UIAssignment.StepDefinitions
{
    public class UIGlobalSteps : TechTalk.SpecFlow.Steps
    {
        public UIGlobalSteps(IWebDriver driver)
        {
            Driver = driver;

        }

        public IWebDriver Driver { get; set; }

        public void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public Login LoginTemplate => new Login(this.Driver);

        public MainPage MainPageTemplate => new MainPage(this.Driver);

    }
}
