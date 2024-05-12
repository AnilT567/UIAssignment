Feature::As a sports user, I would like to read about all articles related to sports


Scenario: Use the search option to find all articles related to ‘sports’. Output the first heading
and the last heading returned on the page.
Given app url https://www.bbc.com/sport/football/scores-fixtures
When Launch Appication
Given Search serch term sports
When Search
Then verify 1 link is Champions League Football Competition
Then verify 4 link is Austrian Bundesligan Football Competition


