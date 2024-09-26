
Feature: TestLoginWithParms

Test login with test data parameters
Background: 
	Given User is on login page

@Sanity
Scenario: Verify login functionality
	When User enter the username and password
	And User click on login button
	Then User is navigated to home page

@Regression
Scenario Outline: Verify login test parameters
	When User enter the "<username>" and "<password>"
	And User click on login button
	Then User is navigated to home page
	Then User selected city and country infomation
	| city   | country |
	| Delhi  | India   |
	| Bostan | USA    |

Examples: 

| username | password |
| tom      | Harry    |
| jerry    | Mathew   |