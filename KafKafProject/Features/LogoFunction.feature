 Feature: Logo functionality

I want to click on logo from other page, so I will be redirected
back to the homepage.


Scenario: [Logo]
	Given that I am on KAFKAF website "https://kafkaf.reteicons.com/"
	And I clicked to check juice products
	When I click on the logo
	Then I should be redirected back to homepage.