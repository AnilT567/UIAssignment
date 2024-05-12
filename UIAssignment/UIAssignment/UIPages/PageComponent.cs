using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAssignment.UIPages
{
    public class PageComponent
    {
        public PageComponent(IWebDriver driver)
        {
            this.Driver = driver;
           
        }

        public IWebDriver Driver { get; }

       
    }
}
