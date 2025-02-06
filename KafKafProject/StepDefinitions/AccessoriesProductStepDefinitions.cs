using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class AccessoriesProductStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        AccessoriesProductPage accessoriesProductPage = new AccessoriesProductPage();

        [Given(@"I navigate on KaffKaff website")]
        public void GivenINavigateOnKaffKaffWebsite()
        {
            //website launched in hooks before scenario();
        }

        [When(@"I hover over the Categories button  on the homepage")]
        public void WhenIHoverOverTheCategoriesButtonOnTheHomepage()
        {
            accessoriesProductPage.UserHoversOnTheCategoriesButton();
        }

        [When(@"I click on the Accessories among dropdown lists")]
        public void WhenIClickOnTheAccessoriesAmongDropdownLists()
        {
            accessoriesProductPage.UserClicksAccessoriesButton();
        }

        [Then(@"the Accessories page is displayed\.")]
        public void ThenTheAccessoriesPageIsDisplayed_()
        {
            accessoriesProductPage.AccessoriesPageIsDisplayed().Contains("Accessories");
        }

        [When(@"I scroll down to view the product grid per page displayed,")]
        public void WhenIScrollDownToViewTheProductGridPerPageDisplayed()
        {
            accessoriesProductPage.ScrollingToViewProductGrid();
        }

        [When(@"I click any page number or the horizontal arrow located in the pagination")]
        public void WhenIClickAnyPageNumberOrTheHorizontalArrowLocatedInThePagination()
        {
            accessoriesProductPage.UserClicksNextArrowPage();
        }

        [Then(@"I can view all Accessories products with each features displayed across the product layout grid\.")]
        public void ThenICanViewAllAccessoriesProductsWithEachFeaturesDisplayedAcrossTheProductLayoutGrid_()
        {
            accessoriesProductPage.UserViewsAllProductsLayout().Contains("Showing 10–12 of 12 results");
        }
    }
}
