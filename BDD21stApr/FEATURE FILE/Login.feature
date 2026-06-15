Feature: Login Feature

Scenario: Valid login test
Given I open the browser
When I navigate to "https://example.com/login"
And I login with following credentials
| username | password |
| admin    | pass123  |
Then login should be successful