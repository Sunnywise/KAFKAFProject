using KafKafProject.Hooks;
using KafKafProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KafKafProject.StepDefinitions
{
    [Binding]
    public class SearchBarFunctionalityStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        SearchBarFunctionalityPage searchBarFunctionalityPage = new SearchBarFunctionalityPage();

        [Given(@"I am on the KafKaf website")]
        public void GivenIAmOnTheKafKafWebsite()
        {
           //declared in basetest
        }

        [When(@"I click on the search bar icon")]
        public void WhenIClickOnTheSearchBarIcon()
        {
            searchBarFunctionalityPage.IClickOnMagnifyingGlass();
        }

        [When(@"I type a product name or keyword in the search bar")]
        public void WhenITypeAProductNameOrKeywordInTheSearchBar()
        {
            searchBarFunctionalityPage.IEnterKeywordInField();
        }

        [When(@"I press Enter or click on the search icon within the search bar")]
        public void WhenIPressEnterOrClickOnTheSearchIconWithinTheSearchBar()
        {
            searchBarFunctionalityPage.IClickOnSearchIcon();
        }

        [Then(@"the website should display relevant product suggestions or search results based on the query")]
        public void ThenTheWebsiteShouldDisplayRelevantProductSuggestionsOrSearchResultsBasedOnTheQuery()
        {
            searchBarFunctionalityPage.AssertResult().Contains("Search results: “Juice”");
        }

        [When(@"i entered a query in the search bar that does not match any product")]
        public void WhenIEnteredAQueryInTheSearchBarThatDoesNotMatchAnyProduct()
        {
            searchBarFunctionalityPage.IInputInvalidText();
        }

        [Then(@"I should see a message displayed below the search box saying, ""([^""]*)""")]
        public void ThenIShouldSeeAMessageDisplayedBelowTheSearchBoxSaying(string p0)
        {
            searchBarFunctionalityPage.NoResultMessageIsDisplayed().Contains("No results");
        }

        [When(@"I press Enter or click on the search icon,")]
        public void WhenIPressEnterOrClickOnTheSearchIcon()
        {
            searchBarFunctionalityPage.IClickOnSearchIcon();
        }

        [Then(@"I should be taken to the product page where it says, ""([^""]*)""")]
        public void ThenIShouldBeTakenToTheProductPageWhereItSays(string p0)
        {
            searchBarFunctionalityPage.NoProductsMatchSelection().Contains("No products were found matching your selection.");
        }

        [When(@"I have entered text in the search bar,")]
        public void WhenIHaveEnteredTextInTheSearchBar()
        {
            searchBarFunctionalityPage.IEnterKeywordInField();
        }

        [When(@"I click the X icon in the search bar,")]
        public void WhenIClickTheXIconInTheSearchBar()
        {
            searchBarFunctionalityPage.XCancelButton();
        }

        [Then(@"the characters typed should be deleted")]
        public void ThenTheCharactersTypedShouldBeDeleted()
        {
            searchBarFunctionalityPage.CharactersShouldBeDelete().Should().BeTrue();
        }
    }
}
