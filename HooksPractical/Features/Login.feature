Feature: Login functionality

# 🔹 OLD SCENARIO
Scenario: Valid login
    Given user is on login page
    When user enters username and password
    Then user should be logged in

# 🔹 NEW DATA DRIVEN SCENARIO
Scenario Outline: Login with multiple users
    Given user is on login page
    When user enters "<username>" and "<password>"
    Then user should see login result

Examples:
    | username | password             |
    | tomsmith | SuperSecretPassword! |
    | wrong    | wrongpass            |