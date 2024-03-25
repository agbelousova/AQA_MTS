Feature: Login
    
    @GUI @Login
    Scenario: Checking the login of a different user
        Given The user logged "<username>" with password "<password>" logged in "<logged in>"
        
    Examples:
      | username        | password     | logged in |
      | locked_out_user | secret_sauce | false     |
      | standard_user   | secret_sauce | true      |