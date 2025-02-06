Feature: ContactUsForm

    As a user visiting the KafKaf website, 
    I want to fill out a Contact Us form with structured fields 
    so that I can easily reach out for support or inquiries.

Scenario Outline: Submitting the Contact Us form with valid and invalid inputs
    Given user is on the KafKaf webpage
    When user scrolls to the footer
    And user clicks on the Contact button
    Then the Contact Us webpage is shown 
    When user scrolls to the Contact Us form
    And user enters his full name as "<Full Name>" in the field
    And user enters email as "<Email Address>" in the field provided
    And user selects any Subject from the dropdown
    And user enters the content of his message as "<Message>"
    And user uploads a file
    And user clicks on the Send button
    Then a "<Confirmatory Message>" is displayed for valid or invalid filling out of the Contact Us form

Examples:
    | Full Name   | Email Address             | Message                             | Confirmatory Message                           |
    | Iyanu Asele | Iyanu.Asele1+@wonders.com | Is product okay for boys and girls ?| Your message has been sent successfully        |
    |             | Iyanu.Asele1+@wonders.com | Is product okay for teens and adult?| This field is required. Please input your name.|
    | Iyanu Asele | Iyanu.Asele1+@wonders     | Is product okay for kids and babies?| This is not a valid email.                     |
