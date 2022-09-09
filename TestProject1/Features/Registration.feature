Feature: Registration
	In other to benefir from the website
	I will need to register

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sing up
	And I enter my Username
	And I enter my email
	And I enter my password
	When I click on the sign up button
	#Then I can register successfully