Scenario Outline: Login test
  Given user enters "<username>" and "<password>"
  Then result should be "<status>"

Examples:
  | username | password | status  |
  | user1    | pass1    | success |
  | user2    | wrong    | fail    |