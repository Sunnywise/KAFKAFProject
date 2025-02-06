Feature: ContactJuiceplusDistributionForm1

As a user on the KafKaf website, 
I want to contact the Juiceplus distributor 
so that i can get the necessary information and support to help start my business.

Background: 
    Given I am a user on kaffkaff website.
    When I click on Start Your Business button
    Then the Start-Your-Business-page is displayed.
    When I click on Start Today With Juiceplus+ button
    Then the Contact Juiceplus Distribution page is displayed.

Scenario Outline: Valid Contact Juiceplus Distribution form submission
	Given I enter <Email address> as my email address.
    And I enter <First Name> in the field as my first name.
    And I enter <Last Name> in the field as my last name.
    And I enter <Phone Number> as phone number.
	And I enter <Message> as the content of the message to the Independent distributor
    And I click on the privacy policy checkbox.
    When I click on the Submit button.
	Then the '<Confirmatory message>' is displayed.
 Examples: 
    | Email address        | First Name       | Last Name | Phone Number  | Message                                                                   | Confirmatory message |
    | ykb.tester@gmail.com | Ifaki-Orinkinran | Imose     | +447894563214 | I am interested to be a major wholesale distributor in Orinkiran Republic | Thank you            |
    | Epistle@apostles.com | Apst.Paul        | Tarsus    | +907234567890 | I want to be the sole retailer in Antioch, Turkey                         | Thank you            |


Scenario Outline: Invalid Contact Juiceplus Distribution form submission
    Given I enter <Email address> as my email address.
    And I enter <First Name> in the field as my first name.
    And I enter <Last Name> in the field as my last name.
    And I enter <Phone Number> as phone number.
	And I enter <Message> as the content of the message to the Independent distributor
    And I click on the privacy policy checkbox.
    When I click on the Submit button.
	Then the '<Confirmatory message>' is displayed.
Examples:
    | Email address        | First Name | Last Name | Phone Number   | Message                                                   | Confirmatory message                       |
    | Testimoney@wonders.  | Test       | Ifaki     | +2347123456789 | How can i register to be the sole retailer in Ifaki-Ekiti | This is not a valid email.                 |
    | Epistle@apostles.com | Paul       | Lasgidi   | +2348036000000 |                                                           | This field is required. Please enter text. |
