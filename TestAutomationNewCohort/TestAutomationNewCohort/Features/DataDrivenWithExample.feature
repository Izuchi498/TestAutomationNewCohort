Feature: DataDrivenWithExample

A short summary of the feature

@tag1
Scenario Outline: Data Driven With Example
	Given I navigate to the website "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password "<Password>"
	When I click on the sign up button
	Then I should be able to register successfully

	Examples:
	| Username | Email             | Password       |
	| Richard11  | Demo1@example.com  | PasswordSecure |
	| Williams2 | Williams2@demo.com | PasswordSecure |
	| Baba3     | Baba4@demo.com     | PasswordSecure |
	

