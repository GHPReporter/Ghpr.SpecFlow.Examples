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
	Given I take number -4
	When I calculate number's absolute value
	Then the result value should be 3
	
@Abs
Scenario: Absolute value zero
	Given I take number 0
	When I calculate number's absolute value
	Then the result value should be 0
	
@Failed
Scenario: Failed by assert
	Given I take number 0
	When I calculate number's absolute value
	Then scenario fails by assert

@Failed
Scenario: Failed with exception
	Given I take number 0
	When I calculate number's absolute value
	Then scenario fails with exception

@Failed
Scenario: Failed by assert inside When
	Given I take number 0
	When this scenario fails by assert
	Then this step should be skipped

@Failed
Scenario: Failed with exception inside When
	Given I take number 0
	When this scenario fails with exception
	Then this step should be skipped
