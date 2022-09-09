Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sing up
	And I enter my Username "chitosamax"
	And I enter my email "samax"
	And I enter my password "password1$"
	#When I click on the sign up button
	Then I can register successfully