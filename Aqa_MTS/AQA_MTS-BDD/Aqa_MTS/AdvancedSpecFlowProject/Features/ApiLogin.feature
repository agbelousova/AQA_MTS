Feature: ApiLogin functionality
    
    @API
    Scenario: Successful login
        Given send request with correct data
        Then response status code is 200
        