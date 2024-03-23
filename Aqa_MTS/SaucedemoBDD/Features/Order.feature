Feature: Order
    
    @GUI @StandartUser
    Scenario: Make a successful order
        Given The user logged standard
        * The user has opened the product catalog page
        * The shopping cart is empty
        When The user added one item to the shopping cart
        * Went to the shopping cart
        * Went to check
        * Filled in the user's data FirstName "Test Name", LastName "Test LastName" and ZipCode "123456"
        * Moved on to the second step of ordering
        * Moved on to the third step of ordering
        Then Order is completed