Feature: YourBusinessYourWay
As a user visiting the KafKaf website,
I want to view the 'Your business, your way " section with a picture on the left and a message on the right
so that I can understand the commitment offered by the company.


Scenario: Verify Your Business, your way section placement 
Given I am on the kafkaf homepage
When  I click the Start Your Business button in the header, positioned immediately to the left of the profile icon, which is located at the far right of the header
Then I should be redirected to the Start Your Business page
When I  scroll down the page
Then I should see the "Your business your way section displayed immediately below the existing section
