using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class YourBusinessYourWayStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        YourBusinessYourWayPage yourBusinessYourWayPage = new YourBusinessYourWayPage();
        [Given(@"I am on the kafkaf homepage")]
        public void GivenIAmOnTheKafkafHomepage()
        {
            
        }

        [When(@"I click the Start Your Business button in the header, positioned immediately to the left of the profile icon, which is located at the far right of the header")]
        public void WhenIClickTheStartYourBusinessButtonInTheHeaderPositionedImmediatelyToTheLeftOfTheProfileIconWhichIsLocatedAtTheFarRightOfTheHeader()
        {
            yourBusinessYourWayPage.UserClickOnStartYourBusiness();
        }

        [Then(@"I should be redirected to the Start Your Business page")]
        public void ThenIShouldBeRedirectedToTheStartYourBusinessPage()
        {
            yourBusinessYourWayPage.AssertStartYourBusinessPage().Contains("Start Your Business");       
        }

        [When(@"I  scroll down the page")]
        public void WhenIScrollDownThePage()
        {
            yourBusinessYourWayPage.ScrollToElement();
        }

        [Then(@"I should see the ""Your business your way section displayed immediately below the existing section")]
        public void ThenIShouldSeeTheYourBusinessYourWaySectionDisplayedImmediatelyBelowTheExistingSection()
        {
            yourBusinessYourWayPage.AssertYourBusinessYourWaySection().Contains("Your business, your way");
        }

    }
}
