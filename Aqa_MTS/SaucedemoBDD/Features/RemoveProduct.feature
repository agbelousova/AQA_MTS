Feature: Deleted the product
    
    @GUI @DeletedProduct
    Scenario: Make a successful order
        Given The user logged standard
        * The user has opened the product catalog page
        * The shopping cart is empty
        When The user added one item to the shopping cart
        * The user deleted the product
        Then The product has been successfully deleted