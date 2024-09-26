Feature: Test Login functionality

Feature to test the login functionality

@Sanity @Regression
Scenario: Verify login functionality
	Given User is on login page
	When User enter the username and password
	And User click on login button
	Then User is navigated to home page
