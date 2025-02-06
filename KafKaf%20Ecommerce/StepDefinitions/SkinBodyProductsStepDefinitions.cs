using KafKafProject.Hooks;
using KafKafProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class SkinBodyProductsStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        Skin_BodyProductsPage skin_BodyProductsPage = new Skin_BodyProductsPage();
        [Given(@"Given I am a user on KafKaf website")]
        public void GivenGivenIAmAUserOnKafKafWebsite()
        {
            
        }

        [When(@"I hover over the ""([^""]*)"" dropdown button on the Kafkaf homepage")]
        public void WhenIHoverOverTheDropdownButtonOnTheKafkafHomepage(string categories)
        {
            skin_BodyProductsPage.UserHoverOnCategories();
        }



        [When(@"I click on Skin & Body in the dropdown list")]
        public void WhenIClickOnSkinBodyInTheDropdownList()
        {
            skin_BodyProductsPage.UserClickOnSkinBody();
        }

        [When(@"I am redirected to Skin & Body page")]
        public void WhenIAmRedirectedToSkinBodyPage()
        {
            skin_BodyProductsPage.RedirectedToAssertPage().Contains("Skin&Body");
        }

        [When(@"I see the first row of product display right under the title '([^']*)' and block of text")]
        public void WhenISeeTheFirstRowOfProductDisplayRightUnderTheTitleAndBlockOfText(string p0)
        {
            skin_BodyProductsPage.UserScrollToProducts();
        }

        [When(@"I select any page number or the horizontal arrow located in the pagination at the bottom of the page, just before the footer")]
        public void WhenISelectAnyPageNumberOrTheHorizontalArrowLocatedInThePaginationAtTheBottomOfThePageJustBeforeTheFooter()
        {
            skin_BodyProductsPage.UserSelectAnyPage();
        }

        [Then(@"I should see all products displayed and each product should display product image, call-to-action button Buy Now, product category, product name, price tag with the ""([^""]*)"" as the currency symbol, quantity in a bracket next to the price")]
        public void ThenIShouldSeeAllProductsDisplayedAndEachProductShouldDisplayProductImageCall_To_ActionButtonBuyNowProductCategoryProductNamePriceTagWithTheAsTheCurrencySymbolQuantityInABracketNextToThePrice(string p0)
        {
            skin_BodyProductsPage.ViewAllProduct().Should().Contain("Skin & Body");
        }
    }
}
