using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class ContactUsFormStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        ContactUsFormPage contactUsFormPage;
        public ContactUsFormStepDefinitions()
        {
             contactUsFormPage = new ContactUsFormPage();
        }
        [Given(@"user is on the KafKaf webpage")]
        public void GivenUserIsOnTheKafKafWebpage()
        {
            contactUsFormPage = new ContactUsFormPage(); ;
        }

        [When(@"user scrolls to the footer")]
        public void WhenUserScrollsToTheFooter()
        {
            contactUsFormPage.UserScrollsToFooter();
        }

        [When(@"user clicks on the Contact button")]
        public void WhenUserClicksOnTheContactButton()
        {
            contactUsFormPage.ContactButtonClicked();
        }

        [Then(@"the Contact Us webpage is shown")]
        public void ThenTheContactUsWebpageIsShown()
        {
            contactUsFormPage.UserIsRedirectedToContactUsPage().Should().Contain("Get In Touch");
        }

        [When(@"user scrolls to the Contact Us form")]
        public void WhenUserScrollsToTheContactUsForm()
        {
            contactUsFormPage.UserScrollsToTheForm();
        }

        [When(@"user enters his full name as ""([^""]*)"" in the field")]
        public void WhenUserEntersHisFullNameAsInTheField(string p0)
        {
            contactUsFormPage.UserEntersFullName(p0);
        }

        [When(@"user enters email as ""([^""]*)"" in the field provided")]
        public void WhenUserEntersEmailAsInTheFieldProvided(string p0)
        {
            contactUsFormPage.UserEntersEmailAddress(p0);
        }

        [When(@"user selects any Subject from the dropdown")]
        public void WhenUserSelectsAnySubjectFromTheDropdown()
        {
            contactUsFormPage.UserSelectSubjectFromDropdown();
        }

        [When(@"user enters the content of his message as ""([^""]*)""")]
        public void WhenUserEntersTheContentOfHisMessageAs(string p0)
        {
            contactUsFormPage.UserEntersMessageInTheFieldProvided(p0);
        }

        [When(@"user uploads a file")]
        public void WhenUserUploadsAFile()
        {
            contactUsFormPage.UserUploadFiles();
        }

        [When(@"user clicks on the Send button")]
        public void WhenUserClicksOnTheSendButton()
        {
            contactUsFormPage.UserClicksOnSendButton();
        }
       
        [Then(@"a ""([^""]*)"" is displayed for valid or invalid filling out of the Contact Us form")]
        public void ThenAIsDisplayedForValidOrInvalidFillingOutOfTheContactUsForm(string p0)
        {
            contactUsFormPage.AConfirmatoryMessageIsDisplayed().Contains(p0);
        }
    }
}
