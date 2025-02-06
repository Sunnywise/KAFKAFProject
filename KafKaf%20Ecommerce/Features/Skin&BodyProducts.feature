Feature: Skin&BodyProducts
As an KafKaf website user, 
I want Skin & Body products displayed on 'Skin & Body' page,
So that I can view the product information

@tag1
Scenario: [Product Layout]
	Given Given I am a user on KafKaf website
	When I hover over the "Categories" dropdown button on the Kafkaf homepage
	And I click on Skin & Body in the dropdown list
	And I am redirected to Skin & Body page
	And I see the first row of product display right under the title 'Skin & Body' and block of text
	And I select any page number or the horizontal arrow located in the pagination at the bottom of the page, just before the footer
	Then I should see all products displayed and each product should display product image, call-to-action button Buy Now, product category, product name, price tag with the "£" as the currency symbol, quantity in a bracket next to the price
