using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class BeveragesAndInfusionsStepDefinitions
    {

        public IWebDriver driver = BaseTest.driver;
        BeveragesAndInfusionsPage beveragesAndInfusionsPage = new BeveragesAndInfusionsPage();

        [Given(@"I am a user on KafKaf website,")]
        public void GivenIAmAUserOnKafKafWebsite()
        {
            //already declare in the Base test class
        }

        [When(@"I hover over the Categories dropdown button on the Kafkaf homepage,")]
        public void WhenIHoverOverTheCategoriesDropdownButtonOnTheKafkafHomepage()
        {
            beveragesAndInfusionsPage.UserHoversOnTheCategoriesButton();
        }

        [When(@"I click on Beverages & Infusions in the dropdown list,")]
        public void WhenIClickOnBeveragesInfusionsInTheDropdownList()
        {
           beveragesAndInfusionsPage.UserSelectsBeverageAndInfusion ();
        }

        [Then(@"I am redirected to Beverages & Infusions page,")]
        public void ThenIAmRedirectedToBeveragesInfusionsPage()
        {
            beveragesAndInfusionsPage.BeveragesAndInfusionPageIsDisplayed().Should().Contain("Beverages & Infusions");
        }

        [When(@"I scroll down to view the three by three product grid per page displayed,")]
        public void WhenIScrollDownToViewTheThreeByThreeProductGridPerPageDisplayed()
        {
            beveragesAndInfusionsPage.UserScrollsToViewProductGrid();
        }

        [When(@"I click any page number or the horizontal arrow located in the pagination at the bottom of the page")]
        public void WhenIClickAnyPageNumberOrTheHorizontalArrowLocatedInThePaginationAtTheBottomOfThePage()
        {
            beveragesAndInfusionsPage.UserClicksNextArrowPage();
        }

        [Then(@"I should see all products with each feature displayed across the product layout grid")]
        public void ThenIShouldSeeAllProductsWithEachFeatureDisplayedAcrossTheProductLayoutGrid()
        {
            beveragesAndInfusionsPage.UserViewsAllProductsLayout().Contains("Showing 10–18 of 18 results");
        }
    }
}
