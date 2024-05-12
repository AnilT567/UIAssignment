Feature: As a QA, I would like to verify all negative scenarios for login

Scenario Outline:  Select ‘Sign in’, and enter as many negative scenarios as possible. Verify that a error
message is displayed and the text that it contains is as expected.

Given app url https://www.bbc.com/sport/football/scores-fixtures
When Launch Appication
    When Click Sign In
    When Try sign in with <email>
    Then verify response <response>
    Examples:
    | email | response |
    | a@abc.com | recognise that email or username. You can try again or register for an account|
     | a@abc.com | We don't recognise that email or username. You can try again or register for an account|
    ||Something's missing. Please check and try again.|
  |  abc@gmail.co| We don't recognise that email or username. You can try again or register for an account|
       |abc@123.com| We don't recognise that email or username. You can try again or register for an account|
    |abc@gmail.net|We don't recognise that email or username. You can try again or register for an account|