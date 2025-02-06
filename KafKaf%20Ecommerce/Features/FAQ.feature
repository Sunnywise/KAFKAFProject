Feature: FAQ

I should be able to read answer to my
choice qeustion on FAQ page


Scenario: Reading answer to FAQ question
	Given that I am on KafKaf website "https://kafkaf.reteicons.com/"
	And I click  on FAQ 
	When I click on my choice question on FAQ page
	Then answer to my choice question is revealed