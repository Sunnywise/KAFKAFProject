using KafKafProject.Hooks;
using OpenQA.Selenium;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class PrivacyPolicyStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        PrivacyPolPgObj privacyPolicy = new PrivacyPolPgObj();

        [Given(@"I am on Kafkaf website ""([^""]*)""")]
        public void GivenIAmOnKafkafWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"When I click on Privacy Policy on the footer of the site")]
        public void WhenWhenIClickOnPrivacyPolicyOnTheFooterOfTheSite()
        {
            privacyPolicy.UserClickPrivacyPolicyButton();
        }

        [Then(@"I should be directed to Privacy Policy page")]
        public void ThenIShouldBeDirectedToPrivacyPolicyPage()
        {
            privacyPolicy.UserDirectedToPrivacyPolicyPage().Should().BeTrue();
        }
    }
}
