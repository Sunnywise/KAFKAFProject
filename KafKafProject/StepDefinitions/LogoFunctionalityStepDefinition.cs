using KafKafProject.Hooks;
using OpenQA.Selenium;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class LogoFunctionalityStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        PgObjects pgObjects = new PgObjects();

        [Given(@"that I am on KAFKAF website ""([^""]*)""")]
        public void GivenThatIAmOnKAFKAFWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I clicked to check juice products")]
        public void GivenIClickedToCheckJuiceProducts()
        {
            pgObjects.ClickOnJuice();
        }

        [When(@"I click on the logo")]
        public void WhenIClickOnTheLogo()
        {
            pgObjects.ClickOnlogo();
        }

        [Then(@"I should be redirected back to homepage\.")]
        public void ThenIShouldBeRedirectedBackToHomepage_()
        {
            pgObjects.RedirectedToHomePage().Should().BeTrue();
        }
    }
}
