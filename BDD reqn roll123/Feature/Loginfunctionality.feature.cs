Feature: Login Functionality

Scenario: Login with multiple users using data table
  Given: I open the browser
  When: I navigate to "https://demoapps.qspiders.com/ui?scenario=1"
  And: I login with following credentials
    | username | password |
    | Mayank1  | pass1    |
    | Mayank2  | pass2    |
  Then: login should be attempted for all users