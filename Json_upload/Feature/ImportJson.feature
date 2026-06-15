Feature: JSON Import

  Scenario: Upload JSON file from system
    Given I open the import page
    When I upload JSON file from desktop
    Then import should be successful