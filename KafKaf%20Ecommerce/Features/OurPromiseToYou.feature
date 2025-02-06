Feature: OurPromiseToYou

As a user on KafKaf website,
I want to see the "Our Promise to You" section
so that I can understand the commitments and assurances offered by the business while viewing the section's content.

@WorkItem22365
Scenario: User can view 'Our promise to you' section
    Given I am on the KafKaf homepage
    When I click the Start Your Business button in the header
    Then I should be redirected to the "Start Your Business" page
    When I scroll down the page
    Then I should see the "Your Business, Your Way" section, having a picture and message content on the left and right side respectively
