using AmazonProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public class SignInSteps
    {
        AutomationPage automationPage;
        public SignInSteps()
        {
            automationPage = new AutomationPage();
        }

        [When(@"I click continue")]
        public void WhenIClickContinue()
        {
            automationPage.ClickContinue();
        }
        
        [Then(@"Click SignIn")]
        public void ThenClickSignIn()
        {
            automationPage.AccountPageIsDisplay();
        }
    }
}
