Feature: Basics
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of numbers

@Addition
Scenario: Add two numbers
	Given I have number 50
	When I add 20
	Then the result sum should be 70

@Addition
Scenario: Add three numbers
	Given I have number 10
	When I add 20
	And I add 7
	Then the result sum should be 37
