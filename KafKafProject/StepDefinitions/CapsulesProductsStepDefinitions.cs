using KafKafProject.Hooks;
using KafKafProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class CapsulesProductsStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        CapsulesProductsPage capsulesProductsPage= new CapsulesProductsPage();

        [Given(@"I navigate on KaffKaff webpage")]
        public void GivenINavigateOnKaffKaffWebpage()
        {
            // code already declared in hooks;
        }

        [When(@"I hover over the Categories button on the homepage of Kafkaf")]
        public void WhenIHoverOverTheCategoriesButtonOnTheHomepageOfKafkaf()
        {
            capsulesProductsPage.UserHoversOnTheCapsulesButton();
        }

        [When(@"I click on the Capsules button amongst the dropdown lists")]
        public void WhenIClickOnTheCapsulesButtonAmongstTheDropdownLists()
        {
            capsulesProductsPage.UserClicksCapsules();
        }

        [Then(@"the Capsules products page is displayed\.")]
        public void ThenTheCapsulesProductsPageIsDisplayed_()
        {
            capsulesProductsPage.CapsulesPageIsDisplayed().Contains("Capsules");
        }

        [Then(@"I scroll down to view the product grid with each features displayed\.")]
        public void ThenIScrollDownToViewTheProductGridWithEachFeaturesDisplayed_()
        {
            capsulesProductsPage.UserScrollsToViewProductGrid();
        }
    }
}
