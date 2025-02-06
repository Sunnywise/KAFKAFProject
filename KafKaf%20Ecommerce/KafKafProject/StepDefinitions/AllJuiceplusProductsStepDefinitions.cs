using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions 
{
    [Binding]

    public class AllJuiceplusProductsStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        AllJuiceplusProductsPage allJuiceplusProductsPage = new AllJuiceplusProductsPage();
        [Given(@"I am a user on Kaff-kaff website")]
        public void GivenIAmAUserOnKaff_KaffWebsite()
        {
            
        }

        [When(@"I hover on '([^']*)' on the Kafkaf homepage,")]
        public void WhenIHoverOnOnTheKafkafHomepage(string shop)
        {
            allJuiceplusProductsPage.UserHoverOnTheShopButton();
        }

        [When(@"I click on '([^']*)' in the dropdown list,")]
        public void WhenIClickOnInTheDropdownList(string p0)
        {
            allJuiceplusProductsPage.UserClickOnJuicePlusButton();  
        }

        [Then(@"I am redirected to the '([^']*)' page, with the first row of the product display\.")]
        public void ThenIAmRedirectedToThePageWithTheFirstRowOfTheProductDisplay_(string Text)
        {
           allJuiceplusProductsPage.RedirectedToAssertPage().Contains("Juiceplus+") ;
        }

        [When(@"I scroll down to view the (.*) x (.*) product grid per page displayed,")]
        public void WhenIScrollDownToViewTheXProductGridPerPageDisplayed(int p0, int p1)
        {
            allJuiceplusProductsPage.UserScrollToProducts();
        }

        [When(@"I select any page number or the horizontal arrow located in the page indicator at the bottom of the page,")]
        public void WhenISelectAnyPageNumberOrTheHorizontalArrowLocatedInThePageIndicatorAtTheBottomOfThePage()
        {
            allJuiceplusProductsPage.UserSelectsAnyPage();
        }

        [Then(@"I should see all products with product category, product-name, Buy-now button, price tag displayed across the product layout grid\.")]
        public void ThenIShouldSeeAllProductsWithProductCategoryProduct_NameBuy_NowButtonPriceTagDisplayedAcrossTheProductLayoutGrid_()
        {
           allJuiceplusProductsPage.UserviewsAllProduct().Should().Contain("Juiceplus+");
        }
    }
}
