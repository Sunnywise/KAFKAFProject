Feature: CapsulesProducts

As an KafKaf website user, 
I want Capsules products displayed on the Capsules page,
So that I can view the product information.

Scenario: Verify user can navigate to Capsules page and view products 
	Given I navigate on KaffKaff webpage
	When I hover over the Categories button on the homepage of Kafkaf
	And I click on the Capsules button amongst the dropdown lists
	Then the Capsules products page is displayed.
	And I scroll down to view the product grid with each features displayed.