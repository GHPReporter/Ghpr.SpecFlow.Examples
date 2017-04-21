Feature: MathTables
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Table
Scenario Outline: Add two numbers from table
	Given I have number '<Number1>'
	When I add '<Number2>'
	Then the result sum should be '<Sum>'

Examples: 
| Number1 | Number2 | Sum |
| 1       | 2       | 3   |
| 2       | 1       | 3   |
| 2       | 2       | 4   |
| 2       | 3       | 5   |
| 2       | 4       | 6   |
| 3       | 2       | 5   |
| 4       | 2       | 6   |
| 5       | 2       | 7   |
| 6       | 2       | 8   |
| 22      | 20      | 42  |
| 23      | 10      | 48  |
| 22      | 20      | 43  |
| 23      | 10      | 44  |

