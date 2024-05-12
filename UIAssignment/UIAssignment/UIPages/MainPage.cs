using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAssignment.Template;

namespace UIAssignment.UIPages
{
    public class MainPage : PageComponent
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public void GetTeamDetails()
        {
            try
            {
                List<TeamData> teams = new List<TeamData>();

                IList<IWebElement> leagues = Driver.FindElements(By.XPath("//div[contains(@class, 'StickyContainer')]"));


                foreach (IWebElement ele in leagues)
                {
                    IList<IWebElement> items = ele.FindElements(By.XPath(".//div[contains(@class, 'StackLayout')]"));

                    foreach (IWebElement item in items)
                    {
                        String text = item.Text;
                        TeamData team = new TeamData();
                        team.LeagueName = ele.FindElement(By.XPath(".//div[contains(@class, 'StickyHeader ')]")).Text;

                        team.HoemTeam = item.FindElement(By.XPath(".//div[contains(@class, 'StyledTeam-HomeTeam')]//div[contains(@class, 'TeamNameWrapper')]//span[contains(@class, 'DesktopValue')]")).Text;
                        team.AwayTeam = item.FindElement(By.XPath(".//div[contains(@class, 'StyledTeam-AwayTeam')]//div[contains(@class, 'TeamNameWrapper')]//span[contains(@class, 'DesktopValue')]")).Text;

                        team.Time = item.FindElement(By.XPath(".//div[contains(@class, 'WithInlineFallback-Scores')]/div/span")).Text;
                        teams.Add(team);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong");
            }

        }


        public void search(string text)
        {
            Driver.FindElement(By.XPath("//input")).SendKeys(text);
        }

        public string GetTextByIndex(int index)
        {
            IList<IWebElement> items = Driver.FindElements(By.XPath("//ul[@role='listbox']/li"));
            return items[index].Text;
        }



    }

}

