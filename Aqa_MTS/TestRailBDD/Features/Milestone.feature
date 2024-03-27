Feature: Milestone

	@GUI @Milestone
	Scenario: Add Milestone
		Given The admin user is logged in
		* The user has created a project
		* The user opened the created project and went to the advanced tab Milestone
		When The user created Milestone
		Then Milestone successfully created