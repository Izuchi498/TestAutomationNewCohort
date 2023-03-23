Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Data Driven With Parameter
Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username "LWP44"
	And I enter my Email "demo@example.com"
	And I enter my password "PasswordSecure"
	When I click on the sign up button
	#Then I should be able to register successfully