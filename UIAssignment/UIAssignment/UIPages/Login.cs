using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UIAssignment.Template;

namespace UIAssignment.UIPages
{
    public class Login : PageComponent
    {
        public Login(IWebDriver driver) : base(driver)
        {

        }
     

      

        public void ClickSignIn()
        {
            Driver.FindElement(By.XPath("//li[contains(@class,'GlobalNavigationProduct-GlobalNavigationNonProductItem-GlobalNavigationAccount')]")).Click();
        }

        public void enterEmail(string email)
        {
            Driver.FindElement(By.XPath("//input[@type= 'email']")).SendKeys(email);
            Driver.FindElement(By.XPath("//button[@type= 'submit']")).Click();
            Thread.Sleep(500);

        }

        public string errorResponse()
        {
       return     Driver.FindElement(By.XPath("//p[@class= 'sb-form-message__content__text']")).Text;
        }
    }
}
