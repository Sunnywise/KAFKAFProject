using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class ContactHerbalifeDistributionStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        ContactHerbalifeDistributionPage contactHerbalifeDistributionPage;
        public ContactHerbalifeDistributionStepDefinitions()
        {
             contactHerbalifeDistributionPage = new ContactHerbalifeDistributionPage();
        }

        [Given(@"I am a user on kaffkaff website")]
        public void GivenIAmAUserOnKaffkaffWebsite()
        {
            contactHerbalifeDistributionPage = new ContactHerbalifeDistributionPage();
        }

        [When(@"I  click on Start Your Business button")]
        public void WhenIClickOnStartYourBusinessButton()
        {
            contactHerbalifeDistributionPage.UserClickOnStartYourBusinessButton();
        }

        [Then(@"the Start Your Business page is displayed\.")]
        public void ThenTheStartYourBusinessPageIsDisplayed_()
        {
            contactHerbalifeDistributionPage.UserIsDirectedToStartYourBusinessPage().Contains("Start Your Business");
        }

        [When(@"I click on Start Today With Herbalife button")]
        public void WhenIClickOnStartTodayWithHerbalifeButton()
        {
            contactHerbalifeDistributionPage.UserClicksOnStartTodayWithHerbalife();
        }

        [Then(@"I am the Contact Herbalife Distribution page is displayed\.")]
        public void ThenIAmTheContactHerbalifeDistributionPageIsDisplayed_()
        {
            contactHerbalifeDistributionPage.RedirectedToDistributionPage();
        }

        [Given(@"I enter (.*) as my email address\.")]
        public void GivenIEnterAsMyEmailAddress_(string p0)
        {
            contactHerbalifeDistributionPage.UserEntersEmail(p0);
        }

        [Given(@"I enter (.*) in the field as my first name\.")]
        public void GivenIEnterInTheFieldAsMyFirstName_(string p0)
        {
            contactHerbalifeDistributionPage.UserEntersFirstName(p0);
        }

        [Given(@"I enter (.*) in the field as my last name\.")]
        public void GivenIEnterInTheFieldAsMyLastName_(string p0)
        {
            contactHerbalifeDistributionPage.UserEntersLastName(p0);
        }

        [Given(@"I enter (.*) as phone number\.")]
        public void GivenIEnterAsPhoneNumber_(string p0)
        {
            contactHerbalifeDistributionPage.UserEntersMobileDigits(p0);
        }

        [Given(@"I enter (.*) as the content of the message to the Independent distributor")]
        public void GivenIEnterAsTheContentOfTheMessageToTheIndependentDistributor(string p0)
        {
            contactHerbalifeDistributionPage.UserEntersMessage(p0);
        }

        [Given(@"I click on the privacy policy checkbox")]
        public void GivenIClickOnThePrivacyPolicyCheckbox()
        {
            contactHerbalifeDistributionPage.UserClicksCheckBox();
        }

        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            contactHerbalifeDistributionPage.UserClicksOnSubmitButton();
        }

        [Then(@"the (.*) is displayed")]
        public void ThenTheIsDisplayed(string p0)
        {
            contactHerbalifeDistributionPage.YourResponseMessage().Contains(p0);
        }
    }
}
