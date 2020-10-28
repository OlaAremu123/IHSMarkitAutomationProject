using IHSMarkitAutomationProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitAutomationProject.Pages
{
    public class DotNetFiddleRunPages
    {
        Context context;

        public DotNetFiddleRunPages(Context _context)
        {
            context = _context;
        }

        By run = By.Id("run-button");
        By optionPanel = By.XPath("//*[@id='CodeForm']/div[2]/div[2]/div[1]/button[1]/span");
        public void ClickOnRunButton()
        {
            context.driver.FindElement(run).Click();
        }
        public bool VerifyHelloWorldIsDisplayedSuccessfully()
        {
            return context.driver.PageSource.Contains("Hello World");
        }
        public void ClickOnOptionPanelButton()
        {
            context.driver.FindElement(optionPanel).Click();
        }
        public bool VerifyGreaterThanSignIsDisplayedSuccessfully()
        {
            return context.driver.PageSource.Contains(">");
        }
    }
}
