Feature: PrivacyPolicy

As a user on Kafkaf site, I want to click Privacy Poilcy button,
so I can read all about Privacy Policy

Scenario: Privacy Policy
	Given I am on Kafkaf website "https://kafkaf.reteicons.com/"
	When When I click on Privacy Policy on the footer of the site
	Then I should be directed to Privacy Policy page
