
    Feature: Calculator

    Scenario: Add two numbers
    Given I enter 5
    And I enter 10
    When I press add
    Then result should be 15

