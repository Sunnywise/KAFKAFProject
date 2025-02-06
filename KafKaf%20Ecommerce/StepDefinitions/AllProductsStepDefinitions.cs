using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class AllProductsStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        AllProductsPage allProductsPage = new AllProductsPage();

        [Given(@"I am a user on KafKaf portal")]
        public void GivenIAmAUserOnKafKafPortal()
        {
            //Already declared and launched in the BaseTest class
        }

        [When(@"I hover over the '([^']*)' dropdown button on the Kafkaf homepage,")]
        public void WhenIHoverOverTheDropdownButtonOnTheKafkafHomepage(string categories)
        {
            allProductsPage.UserHoversOnTheCategoriesButton();
        }

        [When(@"I click on the All products in the dropdown list")]
        public void WhenIClickOnTheAllProductsInTheDropdownList()
        {
            allProductsPage.UserClicksAllProductsButton();
        }

        [Then(@"the page All products is displayed,")]
        public void ThenThePageAllProductsIsDisplayed()
        {
            allProductsPage.AllProductsPageIsDisplayed().Contains("All Products");
        }

        [When(@"I scroll down to view all products grid per page displayed,")]
        public void WhenIScrollDownToViewAllProductsGridPerPageDisplayed()
        {
            allProductsPage.ScrollingToViewAllProductsLayout();
        }

        [When(@"I click any page number or the horizontal arrow located in the pagination at the bottom of the page\.")]
        public void WhenIClickAnyPageNumberOrTheHorizontalArrowLocatedInThePaginationAtTheBottomOfThePage_()
        {
            allProductsPage.UserClicksNextArrowPage();
        }

        [Then(@"I should see all Juiceplus & Herbalife products with each feature displayed across the product layout grid")]
        public void ThenIShouldSeeAllJuiceplusHerbalifeProductsWithEachFeatureDisplayedAcrossTheProductLayoutGrid()
        {
            allProductsPage.UserViewsAllProductsLayout().Contains("Showing 10–18 of 126 results");
        }
    }
}
