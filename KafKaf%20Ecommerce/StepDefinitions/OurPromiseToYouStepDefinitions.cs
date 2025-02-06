using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class OurPromiseToYouStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        OurPromiseToYouPage ourPromiseToYouPage = new OurPromiseToYouPage();

        [Given(@"I am on the KafKaf homepage")]
        public void GivenIAmOnTheKafKafHomepage()
        {
            //Already declared in the BaseTest class();
        }

        [When(@"I click the Start Your Business button in the header")]
        public void WhenIClickTheStartYourBusinessButtonInTheHeader()
        {
            ourPromiseToYouPage.UserClicksOnStartBusinessButton();
        }

        [Then(@"I should be redirected to the ""([^""]*)"" page")]
        public void ThenIShouldBeRedirectedToThePage(string p0)
        {
            ourPromiseToYouPage.AssertStartYourBusinessPage().Contains("Start Your Business");
        }

        [When(@"I scroll down the page")]
        public void WhenIScrollDownThePage()
        {
            ourPromiseToYouPage.UserScrollsToSection();
        }

        [Then(@"I should see the ""([^""]*)"" section, having a picture and message content on the left and right side respectively")]
        public void ThenIShouldSeeTheSectionHavingAPictureAndMessageContentOnTheLeftAndRightSideRespectively(string p0)
        {
            ourPromiseToYouPage.AssertOnOurPromiseToYouPage().Should().Contain("Our promise to you");
        }
    }
}
