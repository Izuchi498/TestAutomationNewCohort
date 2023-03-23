Feature: Registration

As a User
In Order to benefit from the website
I will need to first sign up or register

@tag1
Scenario: Valid Registration
	Given I navigate to the website
	And I click on Sign up
	And I enter Username
	And I enter Email
	And I enter password
	When I click on the sign up button
	Then I should be able to register successfully
