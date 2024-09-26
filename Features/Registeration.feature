Feature: Registration Functionality for ParaBank
 
Test for Registration Functionality in ParaBank
 
 
Scenario Outline: Verify Registration Functionality
	Given User is on Registration Page
	When User enters the "<FirstName>","<LastName>","<Address>","<City>","<State>","<ZipCode>","<Phone>","<SSN>","<UserName>","<Password>" and "<ConfirmPassowrd>"
	And User clicks on Register button
	Then User is navigated to Home page
 
Examples:
 
| FirstName | LastName | Address   | City      | State     | ZipCode | Phone      | SSN    | UserName    | Password   | ConfirmPassowrd |
| Rayan     | Dsilva   | Bantwal   | Mangaluru | Karnataka | 574211  | 9901660111 | ASD125 | rayan sld   | Rayan1@12  | Rayan1@12       |
| Darren    | Dsa      | Kulshek   | Mangaluru | Karnataka | 574234  | 5183838300 | QWE125 | Darren Dsa  | darren@12  | darren@12       |