Feature: Basics feature name
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of numbers
	
@Addition
Scenario: Add two numbers v1
	Given I have number '50'
	When I add '20'
	Then the result sum should be '70'

@Addition
Scenario: Add two numbers v2
	Given I have number '50'
	When I add '20'
	Then the result sum should be '70'

@Addition
Scenario: Add two numbers v3
	Given I have number '50'
	When I add '20'
	Then the result sum should be '70'

@Addition
Scenario: Add two numbers v4
	Given I have number '50'
	When I add '20'
	Then the result sum should be '70'

@Addition
Scenario: Add two numbers v5
	Given I have number '50'
	When I add '20'
	Then the result sum should be '70'

@Addition
Scenario: Add three numbers
	Given I have number '10'
	When I add '20'
	And I add '7'
	Then the result sum should be '37'
