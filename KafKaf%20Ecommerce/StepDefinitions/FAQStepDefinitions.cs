using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class FAQStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        FaqPageObj faqPageObj = new FaqPageObj();

        [Given(@"that I am on KafKaf website ""([^""]*)""")]
        public void GivenThatIAmOnKafKafWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I click  on FAQ")]
        public void GivenIClickOnFAQ()
        {
            faqPageObj.UserClickOnFaq();
        }

        [When(@"I click on my choice question on FAQ page")]
        public void WhenIClickOnMyChoiceQuestionOnFAQPage()
        {
            faqPageObj.UserClickonChoiceQuestion();
        }

        [Then(@"answer to my choice question is revealed")]
        public void ThenAnswerToMyChoiceQuestionIsRevealed()
        {
            faqPageObj.AnswerReveal().Should().BeTrue();
        }
    }
}

