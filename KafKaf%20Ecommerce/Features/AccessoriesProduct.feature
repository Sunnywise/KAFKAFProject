Feature: AccessoriesProduct

As an KafKaf website user, 
I want Accessories products displayed on accessories page,
So that I can view the product information.

Scenario: Verify user can navigate to Accessories page and view products layout
	Given I navigate on KaffKaff website
	When I hover over the Categories button  on the homepage
	And I click on the Accessories among dropdown lists
	Then the Accessories page is displayed.
	When I scroll down to view the product grid per page displayed,
	And I click any page number or the horizontal arrow located in the pagination
	Then I can view all Accessories products with each features displayed across the product layout grid.
