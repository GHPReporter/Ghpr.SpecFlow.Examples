Feature: Other
	In order to avoid silly mistakes
	As a math idiot
	I want to know absolute value of some numbers
	
@Abs
Scenario: Absolute value positive
	Given I take number 50
	When I calculate number's absolute value
	Then the result value should be 50

@Abs
Scenario: Absolute value negative
	Given I take number -3
	When I calculate number's absolute value
	Then the result value should be 3
