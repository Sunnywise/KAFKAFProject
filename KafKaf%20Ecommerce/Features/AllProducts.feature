Feature: AllProducts

As a KafKaf website user, 
I want All products from Herbalife & Juiceplus+ displayed on 'All products' page,
So that I can view the product information.

@WorkItem22889
Scenario: Verify user can view All products (Juiceplus and Herbalife) and it's layout
    Given I am a user on KafKaf portal
    When I hover over the 'Categories' dropdown button on the Kafkaf homepage,
    And I click on the All products in the dropdown list
    Then the page All products is displayed,
    When I scroll down to view all products grid per page displayed,
    And I click any page number or the horizontal arrow located in the pagination at the bottom of the page.
    Then I should see all Juiceplus & Herbalife products with each feature displayed across the product layout grid

