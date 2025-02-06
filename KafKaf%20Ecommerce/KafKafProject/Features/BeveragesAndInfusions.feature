Feature: BeveragesAndInfusions

    As an KafKaf website user, 
    I want Beverages & Infusions products displayed on 'Beverages & Infusions' page,
    So that I can view the product information.

Scenario: Verify user can navigate to Beverages & Infusions page and view products layout
	Given I am a user on KafKaf website,
    When I hover over the Categories dropdown button on the Kafkaf homepage,
    And I click on Beverages & Infusions in the dropdown list,
    Then I am redirected to Beverages & Infusions page,
    When I scroll down to view the three by three product grid per page displayed,
    And I click any page number or the horizontal arrow located in the pagination at the bottom of the page
    Then I should see all products with each feature displayed across the product layout grid

