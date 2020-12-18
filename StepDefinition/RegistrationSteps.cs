

using AmazonProject.PageObject;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace AmazonProject.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        AutomationPage automationPage;
        public RegistrationSteps()
        {
            automationPage = new AutomationPage();
        }

        [Given(@"That i navigate to the website")]
        public void GivenThatINavigateToTheWebsite()
        {
            automationPage.NavigateToTheWebsite();
        }
        
        [When(@"I click on Hello sign in")]
        public void WhenIClickOnHelloSignIn()
        {
            automationPage.ClickOnHelloSignIn();

        }
        
        [When(@"I click on Create your Amazon account")]
        public void WhenIClickOnCreateYourAmazonAccount()
        {
            automationPage.CreateYourAmazonAccount();
        }
        
        [When(@"I enter my Name")]
        public void WhenIEnterMyName()
        {
            automationPage.EnterMyName();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationPage.EnterEmail();
        }
        
       
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string Pwd)
        {
           automationPage.EnterPassword(Pwd);
        }

        [When(@"I re-enter password ""(.*)""")]
        public void WhenIRe_EnterPassword(string RePwd)
        {
            automationPage.RePassword(RePwd);
        }

        [Then(@"I click on Create your Amazon account")]
        public void ThenIClickOnCreateYourAmazonAccount()
        {
            automationPage.CreateAmazonAccount();
        }
    }
}
