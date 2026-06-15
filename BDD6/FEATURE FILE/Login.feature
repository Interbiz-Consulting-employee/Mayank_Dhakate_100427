Feature: Login Functionality

Scenario: Valid login test
Given I open the browser
When I navigate to "https://example.com/login"
And I login with username "admin" and password "pass123"
Then login should be successful