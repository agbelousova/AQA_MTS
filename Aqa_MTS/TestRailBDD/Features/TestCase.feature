Feature: TestCase

	@GUI @TestCase
	Scenario: Add TestCase
		Given The admin user is logged in
		* The user has created a project
		* The user opened the created project and went to the advanced tab TestCase
		When The user created TestCase
		Then TestCase successfully created
	