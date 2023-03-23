Feature: Registration
	In order to benefit from the website
	The user must first register.

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up
	And I enter my username
	And I enter my email
	And I enter my password
	When I click on the sign up button
	#Then I should be able to register successfully