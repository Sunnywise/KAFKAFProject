using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class ContactJuiceplusDistributionForm1StepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        ContactJuiceplusDistributionForm1Page contactJuiceplusDistributionFormPage;
        public ContactJuiceplusDistributionForm1StepDefinitions()
        {
            contactJuiceplusDistributionFormPage = new ContactJuiceplusDistributionForm1Page();
        }
        [Given(@"I am a user on kaffkaff website\.")]
        public void GivenIAmAUserOnKaffkaffWebsite_()
        {

        }

        [When(@"I click on Start Your Business button")]
        public void WhenIClickOnStartYourBusinessButton()
        {
            contactJuiceplusDistributionFormPage.UserClickOnStartYourBusinessButton();
        }

        [Then(@"the Start-Your-Business-page is displayed\.")]
        public void ThenTheStart_Your_Business_PageIsDisplayed_()
        {
            contactJuiceplusDistributionFormPage.UserIsDirectedToStartYourBusinessPage().Contains("Start Your Business");
        }

        [When(@"I click on Start Today With Juiceplus\+ button")]
        public void WhenIClickOnStartTodayWithJuiceplusButton()
        {
            contactJuiceplusDistributionFormPage.UserClicksOnStartTodayWithJuiceplus();
        }

        [Then(@"the Contact Juiceplus Distribution page is displayed\.")]
        public void ThenIAmTheContactJuiceplusDistributionPageIsDisplayed_()
        {
            contactJuiceplusDistributionFormPage.RedirectedToDistributionPage();
        }

        [Given(@"I click on the privacy policy checkbox\.")]
        public void GivenIClickOnThePrivacyPolicyCheckbox_()
        {
            contactJuiceplusDistributionFormPage.UserClicksCheckBox();
        }

        [When(@"I click on the Submit button\.")]
        public void WhenIClickOnTheSubmitButton_()
        {
            contactJuiceplusDistributionFormPage.UserClicksOnSubmitButton();
        }

        [Then(@"the '([^']*)' is displayed\.")]
        public void ThenTheIsDisplayed_(string p0)
        {
            contactJuiceplusDistributionFormPage.YourResponseMessage().Contains(p0);
        }

        //[Then(@"the (.*) is displayed")]
        //public void ThenTheIsDisplayed(string p0)
        //{
        //   // contactJuiceplusDistributionFormPage.YourResponseMessage().Contains(p0);
        //}
    }
}
