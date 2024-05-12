using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UIAssignment.StepDefinitions
{
    [Binding]
    public class Steps : UIGlobalSteps
    {
        public Steps(IWebDriver driver) : base(driver)
        {

        }

        String searchText;
        string appUrl;

        [When(@"Launch Appication")]
        public void SearchTerm()
        {
            Driver.Navigate().GoToUrl(appUrl);
        }

        [Given(@"Search serch term (.*)")]
        public void Launch(String text)
        {
            searchText = text;
        }

        [Given(@"app url (.*)")]
        public void AppUl(String url)
        {
            appUrl = url;
        }

        [When(@"Search")]
        public void Search()
        {
            MainPageTemplate.search(searchText);
            Thread.Sleep(2000);
        }



        [Then(@"verify (.*) link is (.*)")]
        public void VerifyLink(int index, string text)
        {
            string value = MainPageTemplate.GetTextByIndex(index);
            Assert.IsTrue(value.Contains(text.Split(' ')[0]));
        }

        [Then(@"Capture Team Details")]
        public void CaptureTeamDetials()
        {
            MainPageTemplate.GetTeamDetails();

        }

        [When(@"Click Sign In")]
        public void ClickSignIn()
        {
            LoginTemplate.ClickSignIn();
            Thread.Sleep(2000);
        }


        [When(@"Try sign in with (.*)")]
        public void ClickSignIn(string text)
        {
            LoginTemplate.enterEmail(text);
            Thread.Sleep(2000);
        }

        [Then(@"verify response (.*)")]
        public void VerifyResponse(string text)
        {
         if(text.Contains("We don't"))
            {
            text =     text.Replace("We don't", "");
            }
            String response = LoginTemplate.errorResponse();
            Assert.IsTrue(response.Contains( text));
           
        }


    }
}
