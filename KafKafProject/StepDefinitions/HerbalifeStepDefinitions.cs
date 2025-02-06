using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class HerbalifeStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        HerbalifePage herbalifePage =new HerbalifePage();

        [Given(@"I am on any page of the website")]
        public void GivenIAmOnAnyPageOfTheWebsite()
        {
            driver.Navigate().GoToUrl("https://kafkaf.reteicons.com/");
        }

        [When(@"I click on the Shop button on the header menu")]
        public void WhenIClickOnTheShopButtonOnTheHeaderMenu()
        {
            herbalifePage.UserClickOnShopButton();
        }

        [Then(@"Herbalife should display on the drop-down menu")]
        public void ThenHerbalifeShouldDisplayOnTheDrop_DownMenu()
        {
            herbalifePage.UserViewHerbalifeDropdown().Should().BeTrue();
        }
    }
}
