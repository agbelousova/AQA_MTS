Feature: Order

@GUI @StandartUser
Scenario: Make a successful order
	Given The user is logged in
	* The user has opened the product catalog page
	* The shopping cart is empty
	When The user added one item to the shopping cart
	* Went to the shopping cart
	* Moved on to checkout
	* Filled in the user's data FIRSTNAME "TestFIRSTNAME", LASTNAME "TestLASTNAME"
	* Moved on to the second step of ordering
	* Moved on to the third step of ordering
	Then The order is completed