Feature: AllJuiceplusProducts

As an online user on Kaffkaff webpage
I want to see juiceplus+ products displayed on the juiceplus+ page,
So that I can view the product information and arrangement.

Scenario: Navigate and view Juiceplus products on Kaff-kaff website
	Given I am a user on Kaff-kaff website
    When I hover on 'Shop' on the Kafkaf homepage,
    And I click on 'juiceplus+' in the dropdown list,
    Then I am redirected to the 'juiceplus+' page, with the first row of the product display.
    When I scroll down to view the 3 x 3 product grid per page displayed,
    And I select any page number or the horizontal arrow located in the page indicator at the bottom of the page,
    Then I should see all products with product category, product-name, Buy-now button, price tag displayed across the product layout grid.