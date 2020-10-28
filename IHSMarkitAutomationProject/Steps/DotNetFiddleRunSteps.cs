using IHSMarkitAutomationProject.Hooks;
using IHSMarkitAutomationProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace IHSMarkitAutomationProject.Steps
{[Binding]
    public class DotNetFiddleRunSteps
    {
        Context context;
        DotNetFiddleRunPages dotNetFiddleRunPages;
        public DotNetFiddleRunSteps(Context _context, DotNetFiddleRunPages _dotNetFiddleRunPages)
        {
            context = _context;
            dotNetFiddleRunPages = _dotNetFiddleRunPages;
        }
        [Given(@"dotnetfiddle is fully loaded")]
        public void GivenDotnetfiddleIsFullyLoaded()
        {
            context.Initialize();
        }

        [When(@"a user clicks the the run button")]
        public void WhenAUserClicksTheTheRunButton()
        {
            dotNetFiddleRunPages.ClickOnRunButton();
        }

        [Then(@"Hello World text is expected")]
        public void ThenHelloWorldTextIsExpected()
        {
            bool actualResult = dotNetFiddleRunPages.VerifyHelloWorldIsDisplayedSuccessfully();
            Assert.AreEqual(true, actualResult);
        }

        [When(@"a user clicks the the option panel button")]
        public void WhenAUserClicksTheTheOptionPanelButton()
        {
            dotNetFiddleRunPages.ClickOnOptionPanelButton();
        }

        [Then(@"the option panel should be hidden and > displayed successfully")]
        public void ThenTheOptionPanelShouldBeHiddenAndDisplayedSuccessfully()
        {
            bool actualResult = dotNetFiddleRunPages.VerifyGreaterThanSignIsDisplayedSuccessfully();
            Assert.AreEqual(true, actualResult);
        }

        [AfterScenario]
        public void CloseAUT()
        {
            context.CloseAUT();
        }

    }
}
