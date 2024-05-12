Feature: As a business user, I would like to make a record of all teams which are playing toda
  

Scenario: Output all team names with a match today. If there are no matches today, output a message to convey this.
Given app url https://www.bbc.com/sport/football/scores-fixtures
When Launch Appication
Then Capture Team Details

