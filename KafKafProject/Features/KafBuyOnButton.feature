
Feature: KafBuyOnButton

As a user on Kafkaf website, Iwant to click
on Buy on Buttons, so I can access products


Scenario: [Buy on Buttons Function]
	Given that I am on Kafkaf website "https://kafkaf.reteicons.com/"
	When I click on Herbalife button
	Then then I should be directed to herbalife website
	And I am on Kafkaf website "https://kafkaf.reteicons.com/"
	When I click on Buyonjuiceplus+ button
	Then I should be directed to Juiceplus website