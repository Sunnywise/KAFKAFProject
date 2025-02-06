Feature: SearchBarFunctionality
 As a user  on kafkaf website
 I want to be able to click on the search bar icon in the header and search for products on the KafKaf website,  
 So that I can easily find specific products I'm interested in.


Background:
    Given I am on the KafKaf website
    When I click on the search bar icon

Scenario: Search Bar Behavior
	When I type a product name or keyword in the search bar 
    When I press Enter or click on the search icon within the search bar 
    Then the website should display relevant product suggestions or search results based on the query

Scenario: No Results Displayed in Search Dropdown
    When i entered a query in the search bar that does not match any product
    Then I should see a message displayed below the search box saying, "No results"

 Scenario: No Results on Product Page
    When i entered a query in the search bar that does not match any product
    When I press Enter or click on the search icon,
    Then I should be taken to the product page where it says, "No products were found matching your selection."

Scenario: Cancel Search and Clear Input
    When I have entered text in the search bar,
    When I click the X icon in the search bar,
    Then the characters typed should be deleted
