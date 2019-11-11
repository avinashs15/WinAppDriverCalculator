Feature: LaunchAndAddNumbers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given Launch calculator Application
	And I have entered 5 into the calculator
	And I press add
	And I have entered 7 into the calculator
	And I click Equals
	Then the result should be 12 on the screen
	Then I close the calculator
