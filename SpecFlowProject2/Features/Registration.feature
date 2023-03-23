Feature: Registration

As a user
In order to benefit from the website
I will need to first register

@tag1
Scenario: Valid Registration
	Given I navigate to the website
	And I enter first name
	And I enter last name
	And I enter  address
	And I enter email address
	And I enter phone number
	And I enter gender
	And I enter hobbies
	And I enter languages
	And I select skills from the dropdown
	And I select country
	#And I enter select country
	And I enter date of birth
	And I enter password
	And I enter confirm password
	When I click on submit
	Then I should be able to register successfully
